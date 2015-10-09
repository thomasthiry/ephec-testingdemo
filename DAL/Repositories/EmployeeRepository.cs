using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public Employee GetById(int id)
        {
            var query = from employee in _dbContext.Employees
                where employee.Id == id
                select employee;
            return query.SingleOrDefault();
        }

        public void Update(Employee employee)
        {
            _dbContext.Entry(employee).State = EntityState.Modified;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Insert(Employee employee)
        {
            _dbContext.Employees.Add(employee);
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            _dbContext.Employees.Remove(employee);
        }
    }
}
