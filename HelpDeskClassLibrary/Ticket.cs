using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskClassLibrary
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string AssignedAdminUsername { get; set; }
        public string TicketSenderUsername { get; set; }
    }
}
