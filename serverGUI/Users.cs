using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace serverUI
{
    public class Users
    {
        //Thread d'écoute
        Thread thread;
        public Socket Handler { get; set; }
        public string Username { get; set; }

        //Constructeur
        //Chaque utilisateur possede son nom et son handler
        public Users (Socket handler, string username)
        {
            Handler = handler;
            Username = username;
        }

        //Commence la thread d'écoute
        public void Start()
        {
            thread = new Thread(new ThreadStart(EcouterMessage));
            thread.Start();
        }

        //Stop la thread d'écoute
       

        //function d'écoute
        public void EcouterMessage()
        {
            byte[] bytes = new Byte[1024];
            while (true)
            {
                int bytesRec = Handler.Receive(bytes);
                string text = Encoding.Unicode.GetString(bytes, 0, bytesRec);
                if(text == "<dec>") 
                {
                    Form1.consoleText.Add("[USER STATUT] " + Username + " s'est déconnecté");
                    Users userToRemove = Form1.listUsers.Single(u => u.Handler == Handler);
                    Form1.listUsers.Remove(userToRemove);
                    EnvoyerMessage(Username, "removeUser");
                    Deconnecter();
                    break;
                }
                else if (text.StartsWith("<Pmsg>"))
                {
                    MessagePrivé(text, text.Remove(0, 6).Split(':')[1]);
                }
                else
                {
                    Form1.consoleText.Add("[MESSAGE] " + Username + " a écris: " + text);
                    EnvoyerMessage(Username + ": " + text, "Sendmessage");
                }
            }
        }

        public void EnvoyerMessage(string message, string what)
        {
            byte[] msg;
            if (what == "addUser") { 
                msg = Encoding.Unicode.GetBytes("<Ausr>" + message);
                Handler.Send(msg);
            }
            if(what == "Sendmessage")
            {
                msg = Encoding.Unicode.GetBytes(message);
                foreach(Users user in Form1.listUsers) {
                    if(user.Handler != Handler) { user.Handler.Send(msg); }
                }
            }
            if(what == "Deconnecter")
            {
                msg = Encoding.Unicode.GetBytes("<dec>");
                Handler.Send(msg);
            }
            if(what == "removeUser")
            {
                msg = Encoding.Unicode.GetBytes("<Rusr>" + Username);
                foreach (Users user in Form1.listUsers) { user.Handler.Send(msg); }
            }
            
            
            
        }

        public void MessagePrivé(string message, string who)
        {
            byte[] msg;
            Users userToMessage = Form1.listUsers.Single(u => u.Username == who);
            msg = Encoding.Unicode.GetBytes(message);
            userToMessage.Handler.Send(msg);
            Form1.consoleText.Add("[MESSAGE] " + message.Remove(0, 6).Split(':')[0] + " à écrit \"" + message.Remove(0, 2 + message.Split(':')[0].Length + message.Split(':')[1].Length) + "\" à " + userToMessage.Username);
        }

        public void Deconnecter()
        {
            Handler.Shutdown(SocketShutdown.Both);
            Handler.Close();
        }
        
    }
}
