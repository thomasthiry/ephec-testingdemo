using System.Collections.Generic;
using TestingDemo.Domain;

namespace TestingDemo.Application
{
    public interface IEmployeeService
    {
        IList<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        void UpdateEmployee(Employee employee);
        void CreateEmployee(Employee employee);
        void DeleteEmployeeById(int id);
    }
}