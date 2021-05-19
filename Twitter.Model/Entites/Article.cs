using System;
using Twitter.Core.Entities;

namespace Twitter.Model.Entites
{
    public class Article:CoreEntity
    {
        public string ArticleName { get; set; }
        public string ArticleDescription { get; set; }

    }
}
