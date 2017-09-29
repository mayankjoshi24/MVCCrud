using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Core;
using System.Collections;
using Assignment6.Core.Interfaces;

namespace Assignment6.Infrastructure
{
   public class EmployeeRepository : IEmployeeRepository
    {
        EmployeeContext context = new EmployeeContext();
        public void Add(EmployeeUser p)
        {
            context.Employees.Add(p);
            context.SaveChanges();
        }


        public void Edit(EmployeeUser p)
        {
            context.Entry(p).State = System.Data.Entity.EntityState.Modified;
        }

        public EmployeeUser FindById(int Id)
        {
            var result = (from r in context.Employees where r.Id == Id select r).FirstOrDefault();
            return result;
        }

        public IEnumerable GetEmployees() { return context.Employees; }
        public void Remove(int Id) { EmployeeUser p = context.Employees.Find(Id); context.Employees.Remove(p); context.SaveChanges(); }

    }
}
