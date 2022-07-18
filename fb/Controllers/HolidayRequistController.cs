using Microsoft.AspNetCore.Mvc;
using fb.Models.Data;
using System.Collections.Generic;
using fb.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace fb.Controllers
{
    public class HolidayRequistController : Controller
    {
        private readonly AppDbContext _context;

        public HolidayRequistController(AppDbContext context)
        {
            _context = context;
        }

        //// GET: HolidayRequist
        public IActionResult Index()
        {
            IEnumerable<HolidayRequist> objList = _context.HolidayRequists;
            return View(objList);
        }

        ////GET - CREATE
        public IActionResult Create()
        {
            ViewBag.EmployeeId = new SelectList(_context.Employees, "Id", "Id");
            return View();
        }


        //////POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HolidayRequist obj)
        {
            if (ModelState.IsValid)
            {
                _context.HolidayRequists.Add(obj);
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
            var obj = _context.HolidayRequists.Find(id);
           

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(HolidayRequist obj)
        {
            if (ModelState.IsValid)
            {
                _context.HolidayRequists.Update(obj);
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
            var obj = _context.HolidayRequists.Find(id);
            

            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _context.HolidayRequists.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.HolidayRequists.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }

    }
}
