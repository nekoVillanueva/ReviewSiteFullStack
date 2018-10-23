using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public interface ICategoryRepository
    {
       
            IEnumerable<Category> GetAll();
            Category FindById(int id);
        

    }
}
