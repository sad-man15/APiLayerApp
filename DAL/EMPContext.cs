using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EMPContext :DbContext
    {
        public DbSet<Employee> Emplyees { get; set; }
    }
}
