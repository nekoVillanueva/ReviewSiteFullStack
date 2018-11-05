using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(Context db) : base(db)
        {
        }

        public IEnumerable<Tag> GetTagsForReviewId(int reviewId)
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
            // this part is tricky.  trickier than I intended it to be yet.  
            // I'll show you what you need and we'll dig deeper on Monday.
            // This is kind of like nested for loops (when you have multiple froms).
            // but basically we're getting all the reviews (r), then getting all the ReviewTags (t)
            // foreach of the r's, filtering on ReviewId and selecting just the tags.
            // A little much for now, but we'll talk more later in the week.
            var query = from r in GetAll()
                        from t in r.ReviewTags
                        where t.ReviewId == reviewId
                        select t.Tag;
            return query.ToList();
        }
    }
}
