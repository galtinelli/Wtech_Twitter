using System;
using Twitter.Core.Entities.Enum;

namespace Twitter.Core.Entities
{
    public class CoreEntity
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
