using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientGUI
{
    public class Message
    {
        public string message { get; set; }
        public string username { get; set; }
        public string addresse { get; set; }

        public Message(string Message, string Username, string Addresse)
        {
            message = Message;
            username = Username;
            addresse = Addresse;
        }
        public Message()
        {

        }

        public void VerifierMessage()
        {
            if (message.StartsWith("<dec>") || message.StartsWith("<Rusr>") || message.StartsWith("<Ausr>") || message.StartsWith("<Pmsg")) {
                message = " " + message;
            }
        }

    }
}
