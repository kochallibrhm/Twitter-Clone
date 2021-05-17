using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.CORE.Entity.Core
{
    public interface IEntity <T>
    {
        T ID { get; set; }
    }
}
