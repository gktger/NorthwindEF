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

        public static void AddOrderDetails(int OrderID,Product product)
        {
            NorthwindEntities dataContex = new NorthwindEntities();

            Order_Detail order_Detail = new Order_Detail();
            order_Detail.OrderID = OrderID;
            order_Detail.ProductID = product.ProductID;
            order_Detail.Discount = 0;
            order_Detail.Quantity = 10;
            order_Detail.UnitPrice = Convert.ToDecimal(product.UnitPrice);

            dataContex.Order_Details.Add(order_Detail);
            dataContex.SaveChanges();
        }
    }
}
