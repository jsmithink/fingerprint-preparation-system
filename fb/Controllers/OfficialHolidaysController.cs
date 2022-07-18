using fb.Models.Data;
using fb.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace fb.Controllers
{
    public class OfficialHolidaysController : Controller
    {
        private readonly AppDbContext _context;

        public OfficialHolidaysController(AppDbContext context)
        {
            _context = context;
        }
       

        //// GET: OfficialHolidays
        public IActionResult Index()
        {
            IEnumerable<OfficialHolidays> objList = _context.OfficialHolidays;
            return View(objList);
        }

        ////GET - CREATE
        public IActionResult Create()
        {
            ViewBag.AttendanceId = new SelectList(_context.Attendances, "Id", "Id");
       
            return View();
        }


        //////POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OfficialHolidays obj)
        {
            if (ModelState.IsValid)
            {
                _context.OfficialHolidays.Add(obj);
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
            var obj = _context.OfficialHolidays.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(OfficialHolidays obj)
        {
            if (ModelState.IsValid)
            {
                _context.OfficialHolidays.Update(obj);
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
            var obj = _context.OfficialHolidays.Find(id);
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
            var obj = _context.OfficialHolidays.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.OfficialHolidays.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }

    }
}
