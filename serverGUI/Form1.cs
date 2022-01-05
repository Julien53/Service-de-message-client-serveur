using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace serverUI
{
    public partial class Form1 : Form
    {
        //--------------------------------------------------------------------------------------------
        //Variables membres
        public static string data = null;
        public static List<string> consoleText;
        public static List<Users> listUsers;
        
        Users User;
        Thread mainThread;
        Socket listener;
        
        bool threadExist = false, nameExist = false;
        int msgCount = 0;
        
        public Form1()
        {
            InitializeComponent();
            consoleText = new List<string>();
            listUsers = new List<Users>();
            mainThread = new Thread(new ThreadStart(DemarrerServer));
        }

        //--------------------------------------------------------------------------------------------
        //Bouton démarrer
        private void btnDemarrer_Click(object sender, EventArgs e)
        {
            if (threadExist)
            {
                //Donne l'instruction à chaque clients de se déconnecter
               
                int nbrUser = listUsers.Count;
                for (int i = 0; i < nbrUser; i++)
                {
                    listUsers[0].EnvoyerMessage("", "Deconnecter");
                    Thread.Sleep(15 * nbrUser);
                }

                //Ferme le socket d'écoute et la thread
                listener.Close();
                mainThread.Abort();
                btnDemarrer.Text = "Ouvrir server";
                threadExist = false;
                consoleText.Add("[STATUT] " + "Server fermé");
            }
            else
            {
                //Releance la thread principale
                mainThread = new Thread(new ThreadStart(DemarrerServer));
                mainThread.Start();
                btnDemarrer.Text = "Fermer Server";
                threadExist = true;
                consoleText.Add("[STATUT] " + "Server ouvert");
            }
        }

        //--------------------------------------------------------------------------------------------
        //Function d'ecoute des connection entrantes
        public void DemarrerServer()
        {
            byte[] bytes = new Byte[2048];
          
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            // Créez un socket TCP / IP.  
            listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

     

            listener.Bind(localEndPoint);
            listener.Listen(10);

            while (true)
            {
                data = null;
                string dataUsers = "";
                byte[] msg;
                Socket handler = listener.Accept();
                

                // Une connexion entrante doit être traitée.
                int bytesRec = handler.Receive(bytes);
                data = Encoding.Unicode.GetString(bytes, 0, bytesRec);

                //Ajoute l'usager à la liste
                //Envoie les usagers connecter aux clients
                foreach (Users user in listUsers)
                {
                    if(data == user.Username) { nameExist = true; }
                }

                if (!nameExist)
                {
                    consoleText.Add("[USER STATUT] " + data + " s'est connecté au server");
                    User = new Users(handler, data);
                    listUsers.Add(User);
                    foreach (Users user in listUsers)
                    {
                        dataUsers += user.Username + '|';
                        if(User != user) { user.EnvoyerMessage(User.Username, "addUser"); }
                        
                    }
                    
                    User.Start();

                    msg = Encoding.Unicode.GetBytes(dataUsers);

                    handler.Send(msg);
                    nameExist = false;
                }
                else{
                    consoleText.Add("[ERROR] " + "Le nom " + data + " est deja utilisé");
                    msg = Encoding.Unicode.GetBytes("<dec>");
                    handler.Send(msg);
                    nameExist = false;
                }


                // Renvoyez les données au client.  
                
               
            }
        }

        //--------------------------------------------------------------------------------------------
        //Update text 
        private void timer_Tick(object sender, EventArgs e)
        {
            //Affiche les message dans la console
            for (int i = msgCount; i < consoleText.Count; i++)
            {
                consoleServer.Items.Add(consoleText[i]);
                msgCount++;
            }
        }


        //--------------------------------------------------------------------------------------------
        //
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainThread.IsAlive)
            {
                int nbrUser = listUsers.Count;
                for (int i = 0; i < nbrUser; i++)
                {
                    listUsers.First().EnvoyerMessage("", "Deconnecter");
                    Thread.Sleep(10);
                }

                listener.Close();
                mainThread.Abort();
            }
        }
    }
}
