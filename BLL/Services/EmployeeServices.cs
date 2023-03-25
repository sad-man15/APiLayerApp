using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeServices
    {
        public static object Get()
        {
            return EmployeeRepo.Get();
        }
        public static Employee Get(int id)
        {
            return EmployeeRepo.Get(id);
        }

        public static bool Create(Employee emp)
        {
            return EmployeeRepo.Create(emp);
        }
        public static bool Update(Employee emp)
        {
            return EmployeeRepo.Update(emp);
        }

        public static bool Delete(int id)
        {
            return EmployeeRepo.Delete(id);
        }

    }
}
