using NorthwindEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEF.BLL
{
    public static class SupplierBLL
    {
        public static List<Supplier> GetSupplier()
        {
            NorthwindEntities dataContext = new NorthwindEntities();
            return dataContext.Suppliers.ToList();
        }
    }
}
