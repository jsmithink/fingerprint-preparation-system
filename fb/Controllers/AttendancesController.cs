using fb.Models.Data;
using fb.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace fb.Controllers
{
    public class AttendancesController : Controller
    {
        private readonly AppDbContext _context;

        public AttendancesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Attendances

        public IActionResult Index()
        {
            IEnumerable<Attendance> objList = _context.Attendances;
            return View(objList);
        }
        ////GET - CREATE
        public IActionResult Create()
        {
            ViewBag.ShiftId = new SelectList(_context.Shifts, "Id", "Name");

            return View();
        }


        //////POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Attendance obj)
        {
            if (ModelState.IsValid)
            {
                _context.Attendances.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //////GET - EDIT
        public IActionResult Edit(int? id)
        {
            ViewBag.ShiftId = new SelectList(_context.Shifts, "Id", "Name");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.Attendances.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Attendance obj)
        {
            if (ModelState.IsValid)
            {
                _context.Attendances.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            ViewBag.ShiftId = new SelectList(_context.Shifts, "Id", "Name");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.Attendances.Find(id);
           
            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _context.Attendances.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.Attendances.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }
    }
}
   

