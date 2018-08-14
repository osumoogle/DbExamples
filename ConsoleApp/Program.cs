using System;
using System.Data.Entity;
using System.Linq;
using CodeFirst;
using DbFirstContext;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (var codeFirstContext = new CodeFirstDataContext())
            {
                var cfMessages = codeFirstContext.Messages.Include(m => m.User);
                Console.WriteLine(cfMessages.ToList().Count);
            }

            using (var dbFirstContext = new DbFirstEntities())
            {
                var dbfMessages = dbFirstContext.Messages.Include(m => m.Users);
                Console.WriteLine(dbfMessages.ToList().Count);
            }
        }
    }
}
