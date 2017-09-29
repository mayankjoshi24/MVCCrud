using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Core;


namespace Assignment6.Infrastructure
{
   public  class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("ConnectionString")
        {

        }

        public DbSet<EmployeeUser> Employees { get; set; }
    }
}
