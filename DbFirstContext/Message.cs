//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbFirstContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public System.Guid Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public System.Guid UserId { get; set; }
    
        public virtual User User { get; set; }
    }
}
