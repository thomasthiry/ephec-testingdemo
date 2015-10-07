using System.Collections.Generic;
using TestingDemo.DAL.Models;

namespace BLL
{
    public interface IEmployeeService
    {
        IList<Employee> GetEmployees();
    }
}