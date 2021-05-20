using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterClone.API.Dto
{
    public class TagDto
    {
        [Required]
        public string Name { get; set; }

    }
}
