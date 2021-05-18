using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.MODEL.Data;
using TwitterClone.MODEL.Entities;

namespace TwitterClone.MODEL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
