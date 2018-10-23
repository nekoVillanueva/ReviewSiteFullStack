using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        
            public ReviewRepository(Context context) : base(context)
            {
            // This ensures our base constructor gets run.
           
        }
    }
        /*  

          public List<Review>GetAll()
          {
              return ShoeReview.Values.ToList();
          }
          public Review FindById(int id)
          {
              return ShoeReview[id];
          }*/


    
}
