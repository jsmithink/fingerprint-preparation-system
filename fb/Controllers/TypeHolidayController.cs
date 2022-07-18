using fb.Models.Data;
using fb.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using static fb.Models.Entites.TypeHoliday;

namespace fb.Controllers
{
    public class TypeHolidayController : Controller
    {
        
            private readonly AppDbContext _context;

            public TypeHolidayController(AppDbContext context)
            {
                _context = context;
            }

            //// GET: TypeHolidays
            public IActionResult Index()
            {
                IEnumerable<TypeHoliday> objList = _context.TypeHolidays;
                return View(objList);
            }

            ////GET - CREATE
            public IActionResult Create()
            {
            TypeHolidayProvider TP = new TypeHolidayProvider();
            List<TypeHoliday> typeHolidays = TP.GetTypeHolidays();
            IEnumerable<SelectListItem> typeHolidaysEnum = typeHolidays.Select(e => new SelectListItem() { Text = e.Renewal, Value = e.Renewal });
            ViewBag.TypeHoliday = new SelectList(typeHolidaysEnum,"Value", "Text");
            return View();
            }


            //////POST - CREATE
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create(TypeHoliday obj)
            {
                if (ModelState.IsValid)
                {
                    _context.TypeHolidays.Add(obj);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(obj);

            }


            //////GET - EDIT
            public IActionResult Edit(int? id)
            {
            TypeHolidayProvider TP = new TypeHolidayProvider();
            List<TypeHoliday> typeHolidays = TP.GetTypeHolidays();
            IEnumerable<SelectListItem> typeHolidaysEnum = typeHolidays.Select(e => new SelectListItem() { Text = e.Renewal, Value = e.Renewal });
            ViewBag.TypeHoliday = new SelectList(typeHolidaysEnum, "Value", "Text");

            if (id == null || id == 0)
                {
                    return NotFound();
                }
                var obj = _context.TypeHolidays.Find(id);
                if (obj == null)
                {
                    return NotFound();
                }

                return View(obj);
            }

            //POST - EDIT
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Edit(TypeHoliday obj)
            {
                if (ModelState.IsValid)
                {
                    _context.TypeHolidays.Update(obj);
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
                var obj = _context.TypeHolidays.Find(id);
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
                var obj = _context.TypeHolidays.Find(id);
                if (obj == null)
                {
                    return NotFound();
                }
                _context.TypeHolidays.Remove(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");




            }

        }
    }
