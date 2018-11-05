﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ReviewId { get; set; } // Heres your one to many.  One review has many comments.  on the review it's a List<Comment>.  looks great.
    }
}
