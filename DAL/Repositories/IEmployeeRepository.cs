using System.Collections.Generic;
using TestingDemo.DAL.Models;

namespace TestingDemo.DAL.Repositories
{
    public interface IEmployeeRepository
    {
        IList<Employee> GetList();
    }
}