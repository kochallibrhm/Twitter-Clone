using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.MODEL.Data;
using TwitterClone.MODEL.Entities;

namespace TwitterClone.MODEL.Repositories
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
