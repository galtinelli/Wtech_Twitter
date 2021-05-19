using System;
using System.ComponentModel.DataAnnotations.Schema;
using Twitter.Core.Entities;

namespace Twitter.Model.Entites
{
    [Table("User")]
    public class User:CoreEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Tag Tag { get; set; }
    }
}
