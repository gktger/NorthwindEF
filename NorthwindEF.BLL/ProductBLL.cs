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

        public static Product GetProduct(int productID)
        {
            NorthwindEntities dataContext = new NorthwindEntities();
            return dataContext.Products.FirstOrDefault(x => x.ProductID == productID);
        }

        public static void AddProduct(string ProductName,int SupplierID,int CategoryID)
        {
            NorthwindEntities dataContext = new NorthwindEntities();
            Product product = new Product();
            product.ProductName = ProductName;
            product.SupplierID = SupplierID;
            product.CategoryID = CategoryID;
            product.Discontinued = true;

            dataContext.Products.Add(product);
            dataContext.SaveChanges();

        }
    }
}
