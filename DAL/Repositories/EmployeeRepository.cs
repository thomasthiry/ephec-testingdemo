using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingDemo.DAL.Models;

namespace TestingDemo.DAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private TestingDemoContext _dbContext;

        public EmployeeRepository(TestingDemoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<Employee> GetList()
        {
            return _dbContext.Employees.ToList();
        }
    }
}
