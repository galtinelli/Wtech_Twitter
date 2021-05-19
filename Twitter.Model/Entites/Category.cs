using System;
using System.ComponentModel.DataAnnotations.Schema;
using Twitter.Core.Entities;

namespace Twitter.Model.Entites
{
    [Table("Category")]
    public class Category:CoreEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
