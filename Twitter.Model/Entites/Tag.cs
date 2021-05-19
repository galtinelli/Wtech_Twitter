using System;
using System.ComponentModel.DataAnnotations.Schema;
using Twitter.Core.Entities;

namespace Twitter.Model.Entites
{
    [Table("Tag")]
    public class Tag:CoreEntity
    {
        public string TagTitle { get; set; }
        public string TagDescription { get; set; }
        
    }
}
