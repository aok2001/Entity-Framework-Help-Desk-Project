using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace HelpDeskClassLibrary
{
    public class HelpDeskDBContext : DbContext
    {
        public HelpDeskDBContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<UserProfile> Profiles { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<SystemInfo> TicketSysInfo { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"server=192.168.1.81;database=HelpDeskDB;user id=sa;password=P@ssword!");

            // Use one my end localhost
            //options.UseSqlServer(@"server=localhost;database=HelpDeskDB;trusted_connection=true;");
        }
    }
}
