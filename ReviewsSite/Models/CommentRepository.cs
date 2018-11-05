using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(Context db) : base(db)
        {
        }

        public IEnumerable<Comment> GetCommentsForReviewId(int reviewId)
        {
            /*
            var matches = new List<Comment>();
            foreach (var comment in GetAll())
            {
                if (comment.TodoId == todoId)
                {
                    matches.Add(comment.Text);
                }
            }
            return comment;
            */

            return from comment in GetAll()
                   where comment.ReviewId == reviewId
                   orderby comment.CreatedAt
                   select comment; // looks good.
        }
    }
}
