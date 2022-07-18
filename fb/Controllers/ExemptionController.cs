using fb.Models.Data;
using fb.Models.Entites;
using fb.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fb.Controllers
{
    public class ExemptionController : Controller
    {
        private readonly AppDbContext _context;

        public ExemptionController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Exemption
        public ActionResult Filtering(string searchTerm = null)
        {
            var appDBContext = _context.Exemptions.Include(e => e.TypeExemption);
            var model = _context.Hr_Employees
                .Where(H => searchTerm == null || H.NameEmp.StartsWith(searchTerm))
                .Select(H => new Hr_Employee
                {
                    NameEmp = H.NameEmp
                });
            return View(model);
        }
        //****************** end **********************
        public async Task<IActionResult> Index()
        {
            
            var appDBContext = _context.Exemptions.Include(e => e.TypeExemption);
            Filtering();
            return View(await appDBContext.ToListAsync());
            

        }
   
        //public async Task<IActionResult> Index(string SortOrder, string SearchString)
        //{

        //    var appDBContext = _context.Exemptions.Include(e => e.TypeExemption);
        //    ViewData["NameSortParm"] = string.IsNullOrEmpty(SortOrder) ? "name-desc" : " ";
        //    ViewData["DateSortParm"] = SortOrder== "Date"?  "date-desc":"Date";
        //    ViewData["CurrentFilter"] = SearchString;
        //    var Employees = from e in _context.Employees
        //                    select e;
        //    if (!String.IsNullOrEmpty(SearchString))
        //    {
        //        Employees=Employees.Where(e=>e.Name.Contains(SearchString)
        //        || e.Name.Contains(SearchString));
        //    }
        //    Employees = SortOrder switch
        //    {
        //        "name-desc" => Employees.OrderByDescending(e => e.Name),
        //        "Date" => Employees.OrderBy(e => e.EnrollementDate),
        //        "date-desc" => Employees.OrderByDescending(e => e.EnrollementDate),
        //        _ => Employees.OrderBy(e => e.Name),
        //    };
        //    return View(await Employees.AsNoTracking().ToListAsync());


        //}

        ////GET - CREATE
        public IActionResult Create()
        {
            ViewBag.AttendanceId = new SelectList(_context.Attendances, "Id", "Name_Period");
            ViewBag.TypeExemptionId = new SelectList(_context.TypeExemptions, "Id", "TypeOfExemption");
            return View();
        }


        //////POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Exemption obj)
        {
            if (ModelState.IsValid)
            {
                _context.Exemptions.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //////GET - EDIT
        public IActionResult Edit(int? id)
        {
            ViewBag.AttendanceId = new SelectList(_context.Attendances, "Id", "Name_Period");
            ViewBag.TypeExemptionId = new SelectList(_context.TypeExemptions, "Id", "TypeOfExemption");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.Exemptions.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Exemption obj)
        {
            if (ModelState.IsValid)
            {
                _context.Exemptions.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            ViewBag.AttendanceId = new SelectList(_context.Attendances, "Id", "Name_Period");
            ViewBag.TypeExemptionId = new SelectList(_context.TypeExemptions, "Id", "TypeOfExemption");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.Exemptions.Find(id);
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
            var obj = _context.Exemptions.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.Exemptions.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }

    }


