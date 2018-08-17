using System.Linq;
using CodeFirst.Model;

namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.CodeFirstDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst.CodeFirstDataContext context)
        {
            var userRole = new Role
            {
                Id = Guid.NewGuid(),
                Name = "User"
            };
            var adminRole = new Role
            {
                Id = Guid.NewGuid(),
                Name = "Admin"
            };
            if (!context.Roles.Any())
            {
                context.Roles.Add(userRole);
                context.Roles.Add(adminRole);
            }
            else
            {
                userRole = context.Roles.First(r =>r.Name == "User");
                adminRole = context.Roles.First(r => r.Name == "Admin");
            }
            if (context.Users.Any(u => u.UserName == "tony@starklabs.us"))
                return;

            var tony = new User
            {
                FirstName = "Tony",
                LastName = "Stark",
                UserName = "tony@starklabs.us",
                Id = Guid.NewGuid()
            };
            var pepper = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Pepper",
                LastName = "Potts",
                UserName = "pepper@starklabs.us",
            };

            context.Users.Add(tony);
            context.UserRoles.Add(new UserRole {UserId = tony.Id, RoleId = userRole.Id});
            context.UserRoles.Add(new UserRole {UserId = tony.Id, RoleId = adminRole.Id});
            context.UserRoles.Add(new UserRole {UserId = pepper.Id, RoleId = userRole.Id});


            context.Messages.Add(new Message
            {
                UserId = tony.Id,
                Id = Guid.NewGuid(),
                Body = "You better not be on that spaceship!",
                From = pepper.UserName,
                Title = "Hello",
                To = tony.UserName
            });

            context.Users.Add(pepper);

            context.Messages.Add(new Message
            {
                UserId = pepper.Id,
                Id = Guid.NewGuid(),
                Body = "I'm totally not on that spaceship...",
                From = tony.UserName,
                To = pepper.UserName
            });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.SaveChanges();
        }
    }
}
