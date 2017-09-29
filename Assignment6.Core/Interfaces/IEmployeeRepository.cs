using System.Collections;


namespace Assignment6.Core.Interfaces
{
      public interface IEmployeeRepository
    {
            void Add(EmployeeUser e);
            void Edit(EmployeeUser e);
            void Remove(int Id);
            IEnumerable GetEmployees();
            EmployeeUser FindById(int Id);

    }
}
