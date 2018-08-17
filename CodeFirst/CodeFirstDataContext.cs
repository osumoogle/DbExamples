using System.Data.Entity;
using CodeFirst.Model;

namespace CodeFirst
{
    public class CodeFirstDataContext : DbContext
    {
        public CodeFirstDataContext() : base("codeFirst")
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
