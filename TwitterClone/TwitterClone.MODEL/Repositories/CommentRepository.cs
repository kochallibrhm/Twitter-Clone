using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.MODEL.Data;
using TwitterClone.MODEL.Entities;

namespace TwitterClone.MODEL.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
