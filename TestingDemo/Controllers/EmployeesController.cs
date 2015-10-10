using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using TestingDemo.Application;
using TestingDemo.Domain;
using TestingDemo.Infrastructure.Models;
using TestingDemo.ViewModels;

namespace TestingDemo.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeService _employeeService;

        public EmployeesController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: Employees
        public ActionResult Index()
        {
            var employees = _employeeService.GetEmployees();

            return View(Mapper.Map<Collection<EmployeeListItem>>(employees));
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,LastName,FirstName,BirthDate,Salary")] EmployeeEdit employeeEdit)
        {
            if (ModelState.IsValid)
            {
                var employee = Mapper.Map<Domain.Employee>(employeeEdit);
                _employeeService.CreateEmployee(employee);
                return RedirectToAction("Index");
            }

            return View(employeeEdit);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = _employeeService.GetEmployeeById(id.Value);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<EmployeeEdit>(employee));
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LastName,FirstName,BirthDate, Salary")] EmployeeEdit employeeEdit)
        {
            if (ModelState.IsValid)
            {
                var employee = _employeeService.GetEmployeeById(employeeEdit.Id);

                Mapper.Map(employeeEdit, employee);

                _employeeService.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employeeEdit);
        }

        // GET: Employees/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);

            return View(Mapper.Map<EmployeeDelete>(employee));
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _employeeService.DeleteEmployeeById(id);
            return RedirectToAction("Index");
        }
    }
}
