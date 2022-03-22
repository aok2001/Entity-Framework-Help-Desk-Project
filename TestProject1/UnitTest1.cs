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
    }
}