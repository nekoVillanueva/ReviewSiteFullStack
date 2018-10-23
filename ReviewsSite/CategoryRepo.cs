using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class CategoryRepo : Repository<Category>, ICategoryRepository

    {

        public CategoryRepo(Context context) : base(context)
        {
            //This ensures our base constructor gets run.
    
        }
    }
}

