using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TwitterClone.CORE.Entity.Core;

namespace TwitterClone.MODEL.Entities
{
    public class User : CoreEntity
    {
        // Setting created date with constructor
        public User()
        {
            CreatedDate = DateTime.Now;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsAdmin { get; set; }

        // For not restore in db
        [NotMapped]
        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(Name))
                {
                    return "NoName";
                }
                else
                {
                    return Name + " " + LastName;
                }
            }
        }

        public virtual List<Twit> Twits { get; set; }
        public virtual List<Comment> Comments { get; set; }

    }
}
