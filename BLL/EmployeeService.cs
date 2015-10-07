using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingDemo.DAL;
using TestingDemo.DAL.Models;
using TestingDemo.DAL.Repositories;

namespace BLL
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeRepository _employeeRepository;

        public EmployeeService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IList<Employee> GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee { FirstName = "Sarah", LastName = "Connor", BirthDate = new DateTime(1980, 4, 18)},
                new Employee { FirstName = "Frodo", LastName = "Baggins", BirthDate = new DateTime(1951, 2, 1)},
                new Employee { FirstName = "Luke", LastName = "Skywalker", BirthDate = new DateTime(1967, 9, 6)}
            };

            //return _employeeRepository.GetList();
            return employees;
        }
    }
}
