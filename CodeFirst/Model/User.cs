using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Model
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public virtual List<Message> Messages { get; set; }
        public virtual List<UserRole> Roles { get; set; }
    }
}
