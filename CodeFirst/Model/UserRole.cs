using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Model
{
    public class UserRole
    {
        [Key, Column(Order = 0)]
        public Guid UserId { get; set; }
        [Key, Column(Order = 1)]
        public Guid RoleId { get; set; }
    }
}