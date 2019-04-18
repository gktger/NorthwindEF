using NorthwindEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEF.BLL
{
   public static class ProductBLL
    {
        public static List<Product> GetProducts()
        {
            NorthwindEntities dataContext = new NorthwindEntities();
            return dataContext.Products.ToList();
           
        }

       
        
    }
}
