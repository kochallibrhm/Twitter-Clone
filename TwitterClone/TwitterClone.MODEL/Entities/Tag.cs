using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.CORE.Entity.Core;

namespace TwitterClone.MODEL.Entities
{
    public class Tag : CoreEntity
    {
        // Setting created date with constructor
        public Tag()
        {
            CreatedDate = DateTime.Now;
        }

        public string Name { get; set; }

        public virtual List<Twit> Twits { get; set; } 
    }
}
