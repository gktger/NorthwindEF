using NorthwindEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEF.BLL
{
   public static class CategoryBLL
    {
        public static List<Category> GetCategory()
        {
            NorthwindEntities dataContext = new NorthwindEntities();
            return dataContext.Categories.ToList();
        
        }

    }
}
