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
            return _employeeRepository.GetList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetById(id);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.Update(employee);
            _employeeRepository.Save();
        }

        public void CreateEmployee(Employee employee)
        {
            _employeeRepository.Insert(employee);
            _employeeRepository.Save();
        }

        public void DeleteEmployeeById(int id)
        {
            _employeeRepository.Delete(id);
            _employeeRepository.Save();
        }
    }
}
