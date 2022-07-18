using fb.Models.Data;
using fb.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace fb.Controllers
{
    public class OfficialHolidaysDynamicController : Controller
    {
        private readonly AppDbContext _context;

        public OfficialHolidaysDynamicController(AppDbContext context)
        {
            _context = context;
        }

        //// GET: OfficialHolidays
        public IActionResult Index()
        {
            IEnumerable<OfficialHolidaysDynamic> objList = _context.OfficialHolidaysDynamics;
            return View(objList);
        }

        ////GET - CREATE
        public IActionResult Create()
        {
            ViewBag.AttendanceId = new SelectList(_context.Attendances, "Id", "Name_Period");
       
            return View();
        }


        //////POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OfficialHolidaysDynamic obj)
        {
            if (ModelState.IsValid)
            {
                _context.OfficialHolidaysDynamics.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //////GET - EDIT
        public IActionResult Edit(int? id)
        {
            ViewBag.AttendanceId = new SelectList(_context.Attendances, "Id", "Id");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.OfficialHolidaysDynamics.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(OfficialHolidaysDynamic obj)
        {
            if (ModelState.IsValid)
            {
                _context.OfficialHolidaysDynamics.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            ViewBag.AttendanceId = new SelectList(_context.Attendances, "Id", "Id");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.OfficialHolidaysDynamics.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _context.OfficialHolidaysDynamics.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.OfficialHolidaysDynamics.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }

    }
}
