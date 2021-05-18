using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.CORE.Entity.Core;

namespace TwitterClone.MODEL.Entities
{
    public class Comment : CoreEntity
    {
        public Comment()
        {
            CreatedDate = DateTime.Now;
            LikeCount = 0;
        }
        public string Text { get; set; }
        public int LikeCount { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
         

    }
}
