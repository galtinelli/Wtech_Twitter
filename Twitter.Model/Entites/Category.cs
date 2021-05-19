using System;
using Twitter.Core.Entities;

namespace Twitter.Model.Entites
{
    public class Category:CoreEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
