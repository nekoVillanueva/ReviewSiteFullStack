using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class ReviewTag
    {
        // Perfect.  It's an EF entity, so you'll need 2 things (one here and one in the context)
        public int Id { get; set; }

        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }

        public int ReviewId { get; set; }
        public virtual Review Review { get; set; }//so this is where my review information will be?within the reviw tag?  Yup.  We'll write some fancy linq to connect them.  I'll show you soon :)
    }
}
// yup, it also has a Review.  This class is the thing that connects a review and a tag
// nope, a single review
// to show multiple connections between reviews and tags we basically have multiple instances of this class.
// perfect.

    // next up:  A review has a List<ReviewTag> and a Tag has a List<ReviewTag>.  