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

        public static int AddOrders(string CustomerID,int ShipperID)
        {
            NorthwindEntities dataContex = new NorthwindEntities();

            Order order = new Order();
            order.ShipVia = ShipperID;
            order.CustomerID = CustomerID;
            order.EmployeeID = 1;

            dataContex.Orders.Add(order);
            dataContex.SaveChanges();
            return order.OrderID;
        }
       
    }
}
