using NorthwindEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEF.BLL
{
    public static class ShipperBLL
    {
        public static List<Shipper> GetShippers()
        {
            NorthwindEntities dataContext = new NorthwindEntities();
            return dataContext.Shippers.ToList();
        }
    }
}
