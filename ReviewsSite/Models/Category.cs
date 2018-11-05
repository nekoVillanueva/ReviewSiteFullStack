using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }

}
