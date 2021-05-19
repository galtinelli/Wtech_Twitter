using System;
using Twitter.Core.Entities;

namespace Twitter.Model.Entites
{
    public class User:CoreEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
