using Microsoft.AspNetCore.Mvc;
using fb.Models.Data;
using System.Collections.Generic;
using fb.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using fb.Models.Entites;

namespace fb.Controllers
{
    public class Hr_EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public Hr_EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        //// GET: HolidayRequist
        public IActionResult Index()
        {
            IEnumerable<Hr_Employee> objList = _context.Hr_Employees;
            return View(objList);
        }

        ////GET - CREATE
        public IActionResult Create()
        {
           // ViewBag.EmployeeId = new SelectList(_context.Employees, "Id", "Id");
            return View();
        }


        //////POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Hr_Employee obj)
        {
            if (ModelState.IsValid)
            {
                _context.Hr_Employees.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //////GET - EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.Hr_Employees.Find(id);
           

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Hr_Employee obj)
        {
            if (ModelState.IsValid)
            {
                _context.Hr_Employees.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.Hr_Employees.Find(id);
            

            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _context.Hr_Employees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.Hr_Employees.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }

    }
}
