using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelpDeskClassLibrary
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public int AccountType { get; set; } //0 for standard, 1 for admin
        public DateTime DateJoined { get; set; }
        public UserProfile Profile { get; set; }
        public List<Ticket> TicketList { get; set; }

        public User()
        {
            TicketList = new List<Ticket>();
        }

    }
}
