using NUnit.Framework;

using HelpDeskClassLibrary;
using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

       

        [Test]
        public void CreateNewUser()
        {
            User x = new User()
            {
                AccountType = 0,
                DateJoined = DateTime.Now,
                Password = "password",
                Username = "TestUser",
                Profile = new UserProfile()
                {
                    FirstName = "Test",
                    LastName = "User",
                    Occupation = "Salesman",
                    Birthday = DateTime.Now
                }
            };

            HelpDeskDBContext db = new HelpDeskDBContext();
            db.Add(x);
            //Always have to save changes
            db.SaveChanges();
        }

        [Test]
        public void CreateNewAdmin()
        {
            Admin x = new Admin()
            {
                AccountType = 1,
                DateJoined = DateTime.Now,
                Password = "password",
                Username = "TestAdmin",
                Profile = new UserProfile()
                {
                    FirstName = "Test",
                    LastName = "Admin",
                    Occupation = "Administrator",
                    Birthday = DateTime.Now
                }
            };

            HelpDeskDBContext db = new HelpDeskDBContext();
            db.Add(x);
            //Always have to save changes
            db.SaveChanges();
        }

        [Test]
        public void GetUserList()
        {
            List<User> users = new List<User>();

            HelpDeskDBContext db = new HelpDeskDBContext();
            
            users = db.Users.ToList();


            Assert.AreEqual(users, db.Users);
        }

        [Test]
        public void GetAdminList()
        {
            List<Admin> admins = new List<Admin>();

            HelpDeskDBContext db = new HelpDeskDBContext();

            admins = db.Admins.ToList();

            Assert.AreEqual(admins, db.Admins);
        }

        
    }
}