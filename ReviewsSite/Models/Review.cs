using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string reviewCategory { get; set; }
        public string content { get; set; }
        public string ImgUrl { get; set; }
    }
}
