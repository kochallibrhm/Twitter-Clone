using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.MODEL.Entities;

namespace TwitterClone.MODEL.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        public User GetByUserName(string username);
        public User GetByEmail(string email);
    }
}
