using System.Data.Entity;
using CodeFirst.Model;

namespace CodeFirst
{
    public class DataContext : DbContext
    {
        public DataContext() : base("codeFirst")
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
