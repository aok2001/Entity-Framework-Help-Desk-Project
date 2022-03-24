using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace HelpDeskClassLibrary
{
    public class BusinessLayer
    {
        public static User LoggedInUser = null;

        #region "User Management"
        public static bool Register(User user)
        {
            bool ret = false;

            using (HelpDeskDBContext db = new HelpDeskDBContext())
            {
                if (db.Users.Count() == 0 && db.Admins.Count() == 0)
                {
                    if (user.AccountType == 0)
                    {
                        User x = new User()
                        {
                            AccountType = user.AccountType,
                            Username = user.Username,
                            Password = user.Password,
                            DateJoined = user.DateJoined,
                            Profile = user.Profile
                        };

                        ret = true;
                    }
                    else if (user.AccountType == 1)
                    {
                        Admin x = new Admin()
                        {
                            AccountType = user.AccountType,
                            Username = user.Username,
                            Password = user.Password,
                            DateJoined = user.DateJoined,
                            Profile = user.Profile
                        };

                        ret = true;
                    }
                }
                else
                {
                    db.Add(user);
                    ret = true;
                }

                db.SaveChanges();
            }

            return ret;
        }
        public static bool Login(string username, string password)
        {
            bool ret = false;

            using (HelpDeskDBContext db = new HelpDeskDBContext())
            {
                int count = db.Users.Where(x => x.Username == username && x.Password == password).Count();
                if (count == 1)
                {
                    ret = true;
                    LoggedInUser = db.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
                }
                else
                {
                    ret = false;
                }
            }

            return ret;
        }

        

        public static User GetUser(string username, string password)
        {
            User ret = new User();

            using (HelpDeskDBContext db = new HelpDeskDBContext())
            {
                ret = db.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            }

            return ret;
        }

        public static UserProfile GetProfile(User user)
        {          
            User user_with_profile = new User();            

            using (HelpDeskDBContext db = new HelpDeskDBContext())
            {

                user_with_profile = db.Users.Include(x => x.Profile).Where(x => x.Username == user.Username).FirstOrDefault();
                
            }

            return user_with_profile.Profile;
        }

        #endregion

        #region "Lists"

        public static List<Admin> GetAdminList()
        {
            List<Admin> ret = new List<Admin>();

            using (HelpDeskDBContext db = new HelpDeskDBContext())
            {
                ret = db.Admins.ToList();
            }

            return ret;
        }

        public static List<User> GetUserList(User user)
        {
            List<User> ret = new List<User>();

            using (HelpDeskDBContext db = new HelpDeskDBContext())
            {
                ret = db.Users.Where(x => x.Username != user.Username).ToList();
            }

            return ret;
        }

        public static List<Ticket> GetTicketList()
        {
            List<Ticket> ret = new List<Ticket>();

            using (HelpDeskDBContext db = new HelpDeskDBContext())
            {
                ret = db.Tickets.Where(x => x.Status == "Pending").AsEnumerable().ToList();
            }

            return ret;
        }

        public static List<Ticket> GetActiveTicketsList(User user)
        {
            List<Ticket> ret = new List<Ticket>();

            if (user.AccountType == 1)
            {
                using (HelpDeskDBContext db = new HelpDeskDBContext())
                {
                    ret = db.Tickets.Where(x => x.Status == "Active" && x.AssignedAdminUsername == user.Username).AsEnumerable().ToList();
                }
            }

            return ret;
        }

        public static List<Ticket> GetClosedTicketsList(User user)
        {
            List<Ticket> ret = new List<Ticket>();

            if (user.AccountType == 1)
            {
                using (HelpDeskDBContext db = new HelpDeskDBContext())
                {
                    ret = db.Tickets.Where(x => x.Status == "Closed" && x.AssignedAdminUsername == user.Username).AsEnumerable().ToList();
                }
            }

            return ret;
        }

        public static List<Message> GetMessagesList(User sender, User receiver)
        {
            //List<Message> received = new List<Message>();
            //List<Message> sent = new List<Message>();
            List<Message> ret = new List<Message>();            

            using (HelpDeskDBContext db = new HelpDeskDBContext())
            {
                ret = db.Messages.Where(x => (x.ReceiverUsername == receiver.Username && x.SenderUsername == sender.Username) || (x.ReceiverUsername == sender.Username && x.SenderUsername == receiver.Username)).OrderBy(x => x.SentDate).AsEnumerable().ToList();
                //received = db.Messages.Where(x => x.ReceiverUsername == sender.Username && x.SenderUsername == receiver.Username).AsEnumerable().ToList();
            }



            return ret;
        }

        #endregion

        #region "Ticket Management"

        public static Ticket GetSingleTicket(int Id)
        {
            Ticket ret = new Ticket();

            using (HelpDeskDBContext db = new HelpDeskDBContext())
            {
                ret = db.Tickets.Where(x => x.Id == Id).FirstOrDefault();
            }

            return ret;
        }

        public static bool SubmitTicket(Ticket new_ticket)
        {
            bool ret = false;

            using (HelpDeskDBContext db = new HelpDeskDBContext())
            {
                db.Tickets.Add(new_ticket);
                db.SaveChanges();
                ret = true;
            }

            return ret;
        }

        public static bool AcceptTicket(Ticket ticket_to_accept, User user)
        {
            bool ret = false;

            if (user.AccountType == 1)
            {
                using (HelpDeskDBContext db = new HelpDeskDBContext())
                {
                    try
                    {
                        Ticket result = (from p in db.Tickets where p.Id == ticket_to_accept.Id select p).FirstOrDefault();

                        result.Status = "Active";
                        result.AssignedAdminUsername = user.Username;

                        db.SaveChanges();

                        ret = true;
                    }
                    catch
                    {
                        ret = false;
                    }
                }
            }            

            return ret;
        }

        public static bool CloseTicket(Ticket ticket_to_close, User user)
        {
            bool ret = false;

            if (user.AccountType == 1)
            {
                using (HelpDeskDBContext db = new HelpDeskDBContext())
                {
                    try
                    {
                        Ticket result = (from p in db.Tickets where p.Id == ticket_to_close.Id select p).FirstOrDefault();

                        result.Status = "Closed";

                        db.SaveChanges();

                        ret = true;
                    }
                    catch
                    {
                        ret = false;
                    }
                }
            }

            return ret;
        }

        public static bool ReopenTicket(Ticket ticket_to_reopen, User user)
        {
            bool ret = false;

            if (user.AccountType == 1)
            {
                using (HelpDeskDBContext db = new HelpDeskDBContext())
                {
                    try
                    {
                        Ticket result = (from p in db.Tickets where p.Id == ticket_to_reopen.Id select p).FirstOrDefault();

                        result.Status = "Active";

                        db.SaveChanges();

                        ret = true;
                    }
                    catch
                    {
                        ret = false;
                    }
                }
            }

            return ret;
        }

        #endregion

        #region "Messaging"

        public static bool SendMessage(User sender, User receiver, string message)
        {
            bool ret = false;

            using (HelpDeskDBContext db =new HelpDeskDBContext())
            {
                Message new_message = new Message()
                {
                    SenderUsername = sender.Username,
                    ReceiverUsername = receiver.Username,
                    MessageText = message,
                    SentDate = DateTime.Now
                };

                db.Add(new_message);
                db.SaveChanges();
                ret = true;
            }

            return ret;
        }

        #endregion
    }
}
