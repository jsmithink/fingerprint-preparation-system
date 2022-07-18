using fb.Models.Data;
using fb.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fb.Controllers
{
    public class HolidaysController : Controller
    {

            private readonly AppDbContext _context;

            public HolidaysController(AppDbContext context)
            {
                _context = context;
            }

            //// GET: Balance
            public IActionResult Index()
            {
            ViewBag.TypeHolidayId = new SelectList(_context.TypeHolidays, "Id", "HoliName");
            IEnumerable<Holidays> objList = _context.Holidays;
            //Holidays holidays = new Holidays();
            //holidays.Duration= (holidays.ToDate.Date - holidays.FromDate.Date).Days + 1;
            return View(objList);
            }

            ////GET - CREATE
            public IActionResult Create()
            {
            ViewBag.EmployeeId = new SelectList(_context.Employees, "Id", "Id");
            ViewBag.TypeHolidayId = new SelectList(_context.TypeHolidays, "Id", "HoliName");
            return View();
            }


            //////POST - CREATE
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create(Holidays obj)
            {
                if (ModelState.IsValid)
                {
                    _context.Holidays.Add(obj);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(obj);

            }


            //////GET - EDIT
            public IActionResult Edit(int? id)
            {
            ViewBag.EmployeeId = new SelectList(_context.Employees, "Id", "Id");
            ViewBag.TypeHolidayId = new SelectList(_context.TypeHolidays, "Id", "HoliName");
            if (id == null || id == 0)
                {
                    return NotFound();
                }
                var obj = _context.Holidays.Find(id);
                if (obj == null)
                {
                    return NotFound();
                }

                return View(obj);
            }

            //POST - EDIT
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Edit(Holidays obj)
            {
                if (ModelState.IsValid)
                {
                    _context.Holidays.Update(obj);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(obj);

            }

            //GET - DELETE
            public IActionResult Delete(int? id)
            {
            ViewBag.EmployeeId = new SelectList(_context.Employees, "Id", "Id");
            ViewBag.TypeHolidayId = new SelectList(_context.TypeHolidays, "Id", "HoliName");
            if (id == null || id == 0)
                {
                    return NotFound();
                }
                var obj = _context.Holidays.Find(id);
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
                var obj = _context.Holidays.Find(id);
                if (obj == null)
                {
                    return NotFound();
                }
                _context.Holidays.Remove(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");




            }
        public IActionResult Form()
        {
            ViewBag.EmployeeId = new SelectList(_context.Employees, "Id", "Id");
            ViewBag.TypeHolidayId = new SelectList(_context.TypeHolidays, "Id", "HoliName");
            //var appDBContext = _context.Holidays.Include(h => h.TypeHoliday);
            //return View(await appDBContext.ToListAsync());
           return View();




        }


    }
    }
