using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterClone.API.Dto
{
    public class TwitDto
    {
        public string Text { get; set; }
        public Guid UserId { get; set; }

        public virtual List<TagDto> Tags {get; set;}
    }
}
