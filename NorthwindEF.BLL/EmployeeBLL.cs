using NorthwindEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEF.BLL
{
   public static class EmployeeBLL
    {
        public static List<Employee> GetEmployees()
        {
            NorthwindEntities dataContext = new NorthwindEntities();
            return dataContext.Employees.ToList();

            
        }

        public static object GetEmployeesPicture()
        {
            NorthwindEntities dataContext = new NorthwindEntities();
            return dataContext.Employees.Select(x => new { x.Photo }).ToList();



        }

    }
}
