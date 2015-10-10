using System.Collections.Generic;
using TestingDemo.Infrastructure.Models;

namespace TestingDemo.Infrastructure.Repositories
{
    public interface IEmployeeRepository
    {
        IList<Domain.Employee> GetList();
    }
}