using System;
using System.ComponentModel.DataAnnotations.Schema;
using Twitter.Core.Entities;

namespace Twitter.Model.Entites
{
    [Table("Article")]
    public class Article:CoreEntity
    {
        public string ArticleName { get; set; }
        public string ArticleDescription { get; set; }

    }
}
