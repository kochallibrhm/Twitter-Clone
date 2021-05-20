using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.MODEL.Entities;

namespace TwitterClone.MODEL.Repositories
{
    public interface ITwitRepository : IRepository<Twit>
    {
        public List<Twit> GetAllTwitsByUsername(string username);
    }
}
