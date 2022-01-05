using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace clientGUI
{
    public partial class Form1 : Form
    {
        //------------------------------------------------------------------------------------------------------------
        //Variables membres

        
        
        Message message;
        Socket socket;
        IPAddress iPAddress;
        IPEndPoint remoteEP;
        Thread receveur;

        
        byte[] bytes = new byte[1024];
        byte[] byteMsg;

        bool isConnected = false;
        bool textValide;

        List<string> consoleText;
        public Form1()
        {
            InitializeComponent();
            receveur = new Thread(new ThreadStart(EcouterMessage));
            consoleText = new List<string>();
            message = new Message();
            //Emoji list
            emojis.Items.AddRange(

                new Object[] {
                        "😁","😂","😃","😀","😄","😅","😆","😉","😊","😋","😛","😌","😍","😮","😧","😒","😕","😟","😓","😔","😖","😘","😗","😚","😙","😎",
                        "😎","😜","😝","😞","😠","😡","😢","😣","😐","😤","😥","😨","😩","😪","😫","😭","😰","😱","😲","😯","😬","😳","😵","😴","😷","😑",
                        "😈","😇","😦","😶","😸","😹","😺","😻","😼","😽","😾","😿","🙀","🙅","🙆","🙇","🙈","🙉","🙊","🙋","🙍","🙎","🙌","🙏","👀","👂",
                        "👃","👄","👅","👆","👇","👈","👉","👊","👋","👌","👍","👎","👏","👐","⌚","⌛","👦","👧","👨","👩","👪","👫","👮","👯","👰","👱","👲",
                        "👲","👳","👴","👵","👶","👷","👸","👹","👺","👻","👼","👽","👾","🤖","👿","💀","💁","💂","💃","💄","💅","💆","💇","⏩","⏪","⏫",
                        "⏰","⏳","☔","☕","☝","☺","♈","♉","♊","♋","♌","♍","♎","♏","♐","♑","♒","♓","⛎","⚽","⚾","⛄","⛅","⚡","⛪","⛔","⛲",
                        "⛳","⛵","⛺","⛽","🌁","🌂","🌃","🌄","🌅","🌆","🌇","🌈","🌉","🌊","🌋","🌌","🌏","🌜","🌚","🌘","🌗","🌒","🌖","🌝","🌑","🌓",
                        "🌔","🌕","🌙","🌛","🌟","🌠","🌰","🌱","🌴","🌵","🌷","🌸","🌹","🌺","🌻","🌼","🌽","🌾","🌿","🍀","🍁","🍂","🍃","🍄","🍅","🍆",
                        "🍇","🍈","🍉","🍊","🍌","🍍","🍎","🍏","🍑","🍒","🍓","🍔","🍕","🍖","🍗","🍘","🍙","🍚","🍛","🍜","🍝","🍞","🍟","🍠","🍡","🍢",
                        "🍣","🍣","🍥","🍦","🍧","🍨","🍩","🍪","🍫","🍬","🍭","🍮","🍯","🍰","🍱","🍲","🍳","🍴","🍵","🍶","🍷","🍸","🍹","🍺","🍻","🎀","🎁",
                        "🎂","🎃","🎄","🎅","🎆","🎇","🎈","🎉","🎊","🎋","🎌","🎍","🎎","🎏","🎐","🎑","🎒","🎓","🎠","🎡","🎢","🎣","🎤","🎥","🎦","🎧",
                        "🎨","🎩","🎪","🎫","🎬","🎭","🎯","🎰","🎱","🎲","🎳","🎴","🎵","🎶","🎷","🎸","🎹","🎺","🎻","🎼","🎽","🎾","🎿","🏀","🏁","🏂",
                        "🏃","🏄","🏆","🏈","🏊","🏠","🏡","🏢","🏣","🏥","🏦","🏧","🏨","🏩","🏪","🏫","🏬","🏭","🏮","🏯","🏰","🐌","🐍","🐎","🐑","🐒",
                        "🐔","🐗","🐘","🐙","🐚","🐛","🐜","🐝","🐞","🐠","🐟","🐡","🐢","🐣","🐤","🐥","🐦","🐧","🐨","🐩","🐫","🐬","🐭","🐮","🐯","🐰",
                        "🐱","🐲","🐳","🐴","🐵","🐶","🐷","🐸","🐹","🐺","🐻","🐼","🐽","🐾","👑","👒","👓","👔","👕","👖","👗","👘","👙","👚","👛","👜",
                        "👝","👞","👟","👠","👡","👢","👣","👤","💈","💉","💊","💋","💌","💍","💎","💏","💐","💑","💒","💓","💔","💕","💖","💗","💘","💙",
                        "💛","💚","💜","💝","💞","💟","💠","💡","💢","💣","💤","💥","💦","💧","💨","💩","💪","💫","💬","💮","💯","💰","💱","💲","💳","💴",
                        "💵","💸","💹","💺","💻","💼","💽","💾","💿","📀","📁","📂","📃","📄","📅","📆","📇","📈","📉","📊","📋","📌","📍","📎","📏","📐","📑",
                        "📒","📓","📔","📕","📖","📗","📘","📙","📚","📛","📜","📝","📞","📟","📠","📡","📢","📣","📤","📥","📦","📧","📨","📩","📪","📫",
                        "📮","📰","📱","📲","📳","📴","📶","📷","📹","📺","📻","📼","🔃","🔊","🔋","🔌","🔍","🔎","🔏","🔐","🔑","🔒","🔓","🔔","🔖","🔗","🔘",
                        "🔙","🔚","🔛","🔜","🔝","🔞","🔟","🔠","🔡","🔢","🔣","🔤","🔥","🔦","🔧","🔨","🔩","🔪","🔫","🔮","🔯","🔰","🔱","🔲","🔳","🔴",
                        "🔵","🔶","🔷","🔸","🔹","🔺","🔻","🔼","🔽","🗻","🗼","🗽","🗾","🗿","🚀","🚃","🚄","🚅","🚇","🚉","🚌","🚏","🚑","🚒","🚓","🚕",
                        "🚗","🚙","🚚","🚢","🚤","🚥","🚧","🚨","🚩","🚪","🚫","🚬","🚭","🚲","🚶","🚹","🚺","🚻","🚼","🚽","🚾","🛀","🚛","🍐","🚴","🐇",
                        "🚋","🚘","🍼","🚱","🚯","➿","💶","🔭","🌐","📯","💷","👬","🐅","🚦","🔁","🚔","🚊","🐉","🌎","🏉","🛅","🛅","🚍","🏇","🐓","🚣",
                        "🛃","🔂","🚞","🚮","🔄","🐐","🐖","🚳","🚈","🐋","🚆","🌍","🚿","🚂","🐈","🚜","💭","👭","🐁","🐀","🐏","🐕","🚁","📵","🏤","🐂",
                        "🚠","🐄","🚐","🚡","🔈","🔕","📬","🚷","🔬","🛁","🚟","🐊","🚵","🚝","🚸","👥","📭","🐆","🌳","🚖","🍋","🔇","🛄","🔀","🌞","🚎",
                        "🌲","🛂","🚰","🔆","🔅","🕛","🕐","🕑","🕒","🕓","🕔","🕕","🕖", "🕗","🕘","🕙","🕚","🕠","🕤","🕧","🕢","🕦","🕜","🕝","🕞","🕣",
                        "🕟","🕡","🕥","🐃","🏋","💪","🐶","✂","✅","✈","✉","✊","✋","✌","✏","✒","✨","✳","✴","❄","❇","❤","⭐","⭕","〰","〽","㊗","㊙",
                        "🃏","🅰","🅱","🅾","🅿","🆎","🆑","🆒","🆓","🆔","🆕","🆖","🆗","🆘","🆙","🆚","🈁","🈂","🈚","🈯","🈲","🈳","🈴","🈵","🈶","🈷",
                        "🈸","🈹","🈺","🉐","🉑","🌀","☀","☑","☁","☎","♠","♣","♥","♦","♨","♻","♿","⚓","⚠","🀄"
                });

        }

        //------------------------------------------------------------------------------------------------------------
        //Bouton envoyer message
        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            //Verification
            message.message = txtMessage.Text;
            message.VerifierMessage();

            if (!isConnected){ 
                receveurText.Items.Add("Veuillez vous connecter avant");
                return;
            }
            else if (txtMessage.Text.Length > 1024) { 
                receveurText.Items.Add("Message trop long");
                return;
            }
            else if (string.IsNullOrEmpty(txtMessage.Text))
            {
                receveurText.Items.Add("Aucun message ecrit");
                return;
            }
            else if (checkBox1.Checked)
            {
                if(listUser.SelectedIndices.Count != 0) { message.message = "<Pmsg>" + txtUsername.Text + ":" + listUser.SelectedItem + ":" + message.message;}
                else
                {
                    receveurText.Items.Add("Aucun user selectionné pour le message privé");
                    return;
                }
            }
            
            EnvoyerMessage(message);
            receveurText.Items.Add(txtMessage.Text);
            txtMessage.Text = "";
        }

        //------------------------------------------------------------------------------------------------------------
        //Bouton de connection
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            textValide = true;
            if (string.IsNullOrEmpty(txtUsername.Text)) { txtUsername.Text = "Veuillez entrez un nom"; textValide = false; }
            if(string.IsNullOrEmpty(txtAddresse.Text)) { txtAddresse.Text = "Veuillez entrez une addresse"; textValide = false; }

            //Connection si le texte est valide
            if (textValide)
            {
                message = new Message("", txtUsername.Text, txtAddresse.Text);
                btnInterfaceConnecter.Text = "Deconnecter";
                Connection(message);
            }
        }

        //------------------------------------------------------------------------------------------------------------
        //Bouton de interface de connection
        private void btnInterfaceConnecter_Click(object sender, EventArgs e)
        {
            //Affiche l'interface de connection
            if (!isConnected) 
            { 
                interfaceConnection.Visible = true;
                foreach  (Control c in interfaceMessage.Controls) { if (c != interfaceConnection) { c.Enabled = false; } }
                foreach(Control c in interfaceConnection.Controls) { c.Enabled = true; }
            }
            //Deconnection
            else
            {
                isConnected = false;
                btnInterfaceConnecter.Text = "Connecter";
                listUser.Items.Clear();
                receveurText.Items.Add("Deconnecté");
                message.message = "<dec>";
                EnvoyerMessage(message);
                receveur.Abort();
                btnInterfaceConnecter.Text = "Connecter";
                username.Text = "";
            }
        }

        //------------------------------------------------------------------------------------------------------------
        //Function d'envoie
        public void EnvoyerMessage(Message message)
        {
            byteMsg = Encoding.Unicode.GetBytes(message.message);
            socket.Send(byteMsg);
        }

        //------------------------------------------------------------------------------------------------------------
        //Function de connection
        public void Connection(Message message)
        {

            byteMsg = Encoding.Unicode.GetBytes(message.username);
            if(!IPAddress.TryParse(message.addresse, out iPAddress)) { txtAddresse.Text = "Addresse non valide"; return; }
            remoteEP = new IPEndPoint(iPAddress, 11000);
            socket = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);


            try { 

                socket.Connect(remoteEP);
                socket.Send(byteMsg);

                int byteRec = socket.Receive(bytes);
                string text = Encoding.Unicode.GetString(bytes, 0, byteRec);

                //Rajoute tous les usagers connectés à la liste
                if(text != "<dec>")
                {
                    isConnected = true;
                    string[] users = text.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string user in users) { listUser.Items.Add(user); }
                    receveurText.Items.Add("Connection au server réussi");
                    receveur = new Thread(new ThreadStart(EcouterMessage));
                    receveur.Start();
                    interfaceConnection.Visible = false;
                    username.Text = txtUsername.Text;
                    foreach (Control c in interfaceMessage.Controls) { c.Enabled = true; }
                }
                else
                {
                    isConnected = false;
                    btnInterfaceConnecter.Text = "Connecter";
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    receveurText.Items.Add("Le username est déjà utilisé");
                }
            }
            catch (Exception e) 
            { 
                receveurText.Items.Add(e.Message);
                isConnected = false;
                btnInterfaceConnecter.Text = "Connecter";
            }
            
        }



        //------------------------------------------------------------------------------------------------------------
        //Function d'écoute des message entrant
        public void EcouterMessage()
        {
            while (true)
            {
                int byteRec = socket.Receive(bytes);
                string text = Encoding.Unicode.GetString(bytes, 0, byteRec);

                //message Add user
                if (text.StartsWith("<Ausr>")) { 
                    listUser.Items.Add(text.Remove(0, 6));
                    receveurText.Items.Add(text.Remove(0, 6) + " à rejoint le chat");
                }

                //Message remove user
                else if (text.StartsWith("<Rusr>")) 
                {
                    listUser.Items.Remove(text.Remove(0, 6));
                    receveurText.Items.Add(text.Remove(0, 6) + " s'est deconnecté");
                }
               
                //Message deconnect user
                else if (text.StartsWith("<dec>"))
                {
                    receveurText.Items.Add("Deconnecté");
                    message.message = "<dec>";
                    EnvoyerMessage(message);
                    isConnected = false;
                    btnInterfaceConnecter.Text = "Connecter";
                    listUser.Items.Clear();
                    txtUsername.ReadOnly = false;
                    break;
                }
                else if (text.StartsWith("<Pmsg>"))
                {
                    string s = text.Remove(0, 6);
                    receveurText.Items.Add(s.Split(':')[0] + " vous à ecris: " + s.Split(':')[2]);
                }

                //Message add text
                else { receveurText.Items.Add(text); }
                
            }
        }

      
        //------------------------------------------------------------------------------------------------------------
        //Evenemnt lors de la fermeture du formulaire
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnected)
            {
                message.message = "<dec>";
                EnvoyerMessage(message);
                receveur.Abort();
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }


        //------------------------------------------------------------------------------------------------------------
        //Evenement du formulaire
        private void emojis_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtMessage.Text += emojis.SelectedItem;
            emojis.Visible = false;
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            if (emojis.Visible) { emojis.Visible = false; }
            else { emojis.Visible = true; }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Veuillez entrez un nom") { txtUsername.Text = "";  }
        }

        private void txtAddresse_Enter(object sender, EventArgs e)
        {
            if (txtAddresse.Text == "Veuillez entrez une addresse" || txtAddresse.Text == "Addresse non valide") { txtAddresse.Text = ""; }
        }

      
    }
}
