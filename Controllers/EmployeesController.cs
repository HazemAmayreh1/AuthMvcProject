using Microsoft.AspNetCore.Mvc;
using mvcOne.Data;
using mvcOne.Models;

namespace mvcOne.Controllers
{
    public class EmployeesController : Controller
    {
        AppDbContext context = new AppDbContext();
        public IActionResult Index()
        {
            var employee = context.Employees.ToList();
        return View(employee); 
        }
        public IActionResult GetOne(int id)
        {
            return View();
        }

        public IActionResult errorHandel()
        {
            return Content("Eroor page ...........");
        }
        public IActionResult Create()
        {
            return View();
        }
        
        public IActionResult Edit(int id)
        {
            var employee = context.Employees.Find(id);
           return View(employee);

        }
        public IActionResult Update(Employee emp)
        {
            var employee = context.Employees.Find(emp.Id);

            employee.Name = emp.Name;
            employee.Email = emp.Email;
            employee.Passwored = emp.Passwored; 
            context.SaveChanges();
            return RedirectToAction("Index");
        }



        public IActionResult Delete(int id)
        {
            var employye = context.Employees.Find(id);
            context.Employees.Remove(employye);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Store(Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
