using System;
using Twitter.Core.Entities;

namespace Twitter.Model.Entites
{
    public class Comment:CoreEntity
    {
        public string CommentTitle { get; set; }
        public string CommentDescription { get; set; }
    }
}
