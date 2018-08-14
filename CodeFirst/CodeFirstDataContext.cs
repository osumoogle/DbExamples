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
    }
}
