using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.CORE.Entity.Core
{
    public class CoreEntity : IEntity<Guid>
    {
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
