using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using TestingDemo.Infrastructure.Models;

namespace TestingDemo.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private TestingDemoContext _dbContext;

        public EmployeeRepository(TestingDemoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<Domain.Employee> GetList()
        {
            var employees = _dbContext.Employees.ToList();
            return Mapper.Map< IList<Domain.Employee>>(employees);
        }

        public Domain.Employee GetById(int id)
        {
            var employee = GetEmployeeFromDbById(id);

            return Mapper.Map<Domain.Employee>(employee);
        }

        public void Update(Domain.Employee employee)
        {
            var employeeEF = GetEmployeeFromDbById(employee.Id);

            Mapper.Map(employee, employeeEF);

            _dbContext.Entry(employeeEF).State = EntityState.Modified;
        }

        public void Insert(Domain.Employee employee)
        {
            var employeeEF = Mapper.Map<Employee>(employee);
            _dbContext.Employees.Add(employeeEF);
        }

        public void Delete(int id)
        {
            var employee = GetEmployeeFromDbById(id);
            _dbContext.Employees.Remove(employee);
        }

        private Employee GetEmployeeFromDbById(int id)
        {
            var query = from employee in _dbContext.Employees
                        where employee.Id == id
                        select employee;
            return query.SingleOrDefault();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
