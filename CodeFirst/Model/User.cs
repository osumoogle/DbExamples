using System;
using System.Collections.Generic;

namespace CodeFirst.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public virtual List<Message> Messages { get; set; }
    }
}
