using System;
using Twitter.Core.Entities;

namespace Twitter.Model.Entites
{
    public class Tag:CoreEntity
    {
        public string TagTitle { get; set; }
        public string TagDescription { get; set; }
    }
}
