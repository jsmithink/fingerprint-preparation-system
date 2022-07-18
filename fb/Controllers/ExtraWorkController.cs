using Microsoft.AspNetCore.Mvc;
using fb.Models.Data;
using System.Collections.Generic;
using fb.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace fb.Controllers
{
    public class ExtraWorkController : Controller
    {
        private readonly AppDbContext _context;

        public ExtraWorkController(AppDbContext context)
        {
            _context = context;
        }

        //// GET: HolidayRequist
        public IActionResult Index()
        {
            IEnumerable<ExtraWork> objList = _context.ExtraWorks;
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
        public IActionResult Create(ExtraWork obj)
        {
            if (ModelState.IsValid)
            {
                _context.ExtraWorks.Add(obj);
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
            var obj = _context.ExtraWorks.Find(id);
           

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ExtraWork obj)
        {
            if (ModelState.IsValid)
            {
                _context.ExtraWorks.Update(obj);
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
            var obj = _context.ExtraWorks.Find(id);
            

            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _context.ExtraWorks.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.ExtraWorks.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }

    }
}
