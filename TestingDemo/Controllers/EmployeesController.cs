using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BLL;
using TestingDemo.DAL;
using TestingDemo.DAL.Models;

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

            return View(employees);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,LastName,FirstName,BirthDate")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.CreateEmployee(employee);
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _employeeService.GetEmployeeById(id.Value);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LastName,FirstName,BirthDate")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);
            return View(employee);
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
