using System;
using System.Collections.Generic;
using System.Linq;
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

        public User GetByEmail(string email)
        {
            return GetAll().FirstOrDefault(p => p.Email.Equals(email));
        }

        public User GetByUserName(string username)
        {
            return GetAll().FirstOrDefault(p => p.Username.Equals(username));
        }
    }
}
