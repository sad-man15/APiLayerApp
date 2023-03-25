using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class EmployeeRepo
    {
        static EMPContext db;
        static EmployeeRepo()
        {
            db = new EMPContext();
        }
        public static object Get()
        {
            return db.Emplyees.ToList();
        }
        public static Employee Get(int id)
        {
            return db.Emplyees.Find(id);
        }

        public static bool Create(Employee em)
        {
           db.Emplyees.Add(em);
            return db.SaveChanges() > 0;
        }
        public static bool Update(Employee em)
        {
            var exEmp = Get(em.Id);
            db.Entry(exEmp).CurrentValues.SetValues(em);
            return db.SaveChanges() > 0;
        }

        public static bool Delete(int id)
        {
            var exEmp = Get(id);
            db.Emplyees.Remove((Employee)exEmp);
            return db.SaveChanges() > 0;
        }
    }
}
