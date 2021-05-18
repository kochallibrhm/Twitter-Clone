﻿using System;
using System.Collections.Generic;
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
    }
}
