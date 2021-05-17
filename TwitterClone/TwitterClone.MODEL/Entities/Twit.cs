using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.CORE.Entity.Core;

namespace TwitterClone.MODEL.Entities
{
    public class Twit : CoreEntity
    {
        // Setting created date with constructor
        public Twit()
        {
            CreatedDate = DateTime.Now;
        }

        public string Text { get; set; }
        public int LikeCount { get; set; }

        public Guid UserID { get; set; }
        public virtual User User { get; set; }
        public virtual List<Tag> Tags { get; set; }


    }
}
