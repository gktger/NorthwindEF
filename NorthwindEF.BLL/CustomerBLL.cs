using NorthwindEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEF.BLL
{
    public static class CustomerBLL
    {
        public static List<Customer> GetCustomers()
        {
            NorthwindEntities dataContext = new NorthwindEntities();
            return dataContext.Customers.ToList();


        }

        public static List<Customer> SearchCustomers(string text)
        {
            NorthwindEntities dataContext = new NorthwindEntities();


            return dataContext.Customers.Where(x => x.ContactName.Contains(text)).ToList();
                            
        }
    }
}
