using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Model
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}