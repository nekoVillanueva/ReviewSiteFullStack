using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public string CategoryType { get; set; }
        public string Content { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<ReviewTag> ReviewTags { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}//does this look ok or should it be List<reviewtag.so the tag itslef wont be here ?itll be within the review tag?
                                          //^ yup                                                       ^yessir

