using SampleMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace SampleMVC.Data
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<CoreContext>
    {
        protected override void Seed(CoreContext context)
        {
            var users = new List<User>
            {
                new User() { FirstName = "John", MiddleName = "Frank", LastName = "Doe", DOB = DateTime.Parse("1980-01-01") },
                new User() { FirstName = "Jane", MiddleName = "Frank", LastName = "Doe", DOB = DateTime.Parse("1986-01-01") },
                new User() { FirstName = "Mark", MiddleName = "Frank", LastName = "Smith", DOB = DateTime.Parse("1972-01-01") },
                new User() { FirstName = "Mary", MiddleName = "Frank", LastName = "Smith", DOB = DateTime.Parse("1975-01-01") }
            };

            users.ForEach(u => context.Users.Add(u));

            base.Seed(context);
        }
    }
}