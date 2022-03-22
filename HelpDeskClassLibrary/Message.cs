using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskClassLibrary
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public string SenderUsername { get; set; }
        public string ReceiverUsername { get; set; }
        public DateTime SentDate { get; set; }
    }
}
