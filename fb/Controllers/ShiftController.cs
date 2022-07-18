using fb.Models.Data;
using fb.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace fb.Controllers
{
    public class ShiftController : Controller
    {
        private readonly AppDbContext _context;

        public ShiftController(AppDbContext context)
        {
            _context = context;
        }

        //// GET: Balance
        public IActionResult Index()
        {
            IEnumerable<Shift> objList = _context.Shifts;
            return View(objList);
        }

        ////GET - CREATE
        public IActionResult Create()
        {
            return View();
        }


        //////POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Shift obj)
        {
            if (ModelState.IsValid)
            {
                _context.Shifts.Add(obj);
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
            var obj = _context.Shifts.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Shift obj)
        {
            if (ModelState.IsValid)
            {
                _context.Shifts.Update(obj);
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
            var obj = _context.Shifts.Find(id);
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
            var obj = _context.Shifts.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.Shifts.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }

    }
}
