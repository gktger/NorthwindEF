using NorthwindEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEF.BLL
{
    public static class OrderDetailBLL
    {

        public static List<Order_Detail> GetOrder_Details(int OrderID)
        {
            NorthwindEntities dataContext = new NorthwindEntities();
            return dataContext.Order_Details.Where(x => x.OrderID == OrderID).ToList();
        }
    }
}
