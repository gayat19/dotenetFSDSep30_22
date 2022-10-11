using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>
        {
            new Employee{Id=101,Name="Ramu",Age=32},
            new Employee{Id=102,Name="Somu",Age=39},
            new Employee{Id=103,Name="Komu",Age=22}
        };
        public IActionResult Index()
        {
            ViewBag.Employees = employees;
            return View(employees);
        }
        public IActionResult Details(int id)
        {
            // Employee employee = employees[0];
            Employee employee = employees.FirstOrDefault(emp => emp.Id == id);
            return View(employee);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employees.Add(employee);
            ViewBag.Message = "Employee added";
            //return View();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            // Employee employee = employees[0];
            Employee employee = employees.FirstOrDefault(emp => emp.Id == id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(int id,Employee employee)
        {
            Employee myEmployee = employees.FirstOrDefault(emp => emp.Id == id);
            myEmployee.Name = employee.Name;
            myEmployee.Age = employee.Age;
            //return View();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            // Employee employee = employees[0];
            Employee employee = employees.FirstOrDefault(emp => emp.Id == id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(int id, Employee employee)
        {
            Employee myEmployee = employees.FirstOrDefault(emp => emp.Id == id);
            employees.Remove(myEmployee);
            return RedirectToAction("Index");
        }
    }
}
