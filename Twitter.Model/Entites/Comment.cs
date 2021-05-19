using System;
using System.ComponentModel.DataAnnotations.Schema;
using Twitter.Core.Entities;

namespace Twitter.Model.Entites
{
    [Table("Comment")]
    public class Comment:CoreEntity
    {
        public string CommentTitle { get; set; }
        public string CommentDescription { get; set; }
    }
}
