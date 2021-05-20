using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwitterClone.MODEL.Data;
using TwitterClone.MODEL.Entities;

namespace TwitterClone.MODEL.Repositories
{
    public class TwitRepository : GenericRepository<Twit>, ITwitRepository
    {
        public TwitRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public List<Twit> GetAllTwitsByUsername(string username)
        {
            return GetAll().Where(p => p.User.Username.Equals(username)).ToList();
        }
    }
}
