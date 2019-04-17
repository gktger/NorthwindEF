using NorthwindEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEF.BLL
{
   public static class OrderBLL
    {
        public static List<Order> GetOrders(string CustomerID)
        {
            NorthwindEntities dataContex = new NorthwindEntities();
            return dataContex.Orders.Where(x => x.CustomerID == CustomerID).ToList();
        }
    }
}
