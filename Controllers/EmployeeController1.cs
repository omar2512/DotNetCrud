using Microsoft.AspNetCore.Mvc;
using CrudOperation.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOperation.Controllers
{
    public class EmployeeController1 : Controller
    {
        public EmployeeDBcontext dbcontext;
        public EmployeeController1(EmployeeDBcontext employeeDBcontext)
        {
            dbcontext = employeeDBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employelist =await dbcontext.Employees.ToListAsync();
            return View(employelist);   
        }
        [HttpGet]
        public IActionResult ADD()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ADD(Employee empoye)
        {
            await dbcontext.Employees.AddAsync(empoye);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("ADD");
        }
        [HttpGet]
        public async Task<IActionResult> View(int? id)
        {
            var employe =await dbcontext.Employees.FirstOrDefaultAsync(x => x.Id == id);
           
                return await Task.Run(()=> View("View",employe));
            
           

        }
        [HttpPost]
        public async Task<IActionResult> View(Employee employss)
        {


            dbcontext.Update(employss);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Employee employss)
        {
            dbcontext.Remove(employss);
            await dbcontext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
    }
