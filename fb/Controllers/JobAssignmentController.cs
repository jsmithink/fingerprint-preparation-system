using Microsoft.AspNetCore.Mvc;
using fb.Models.Data;
using System.Collections.Generic;
using fb.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace fb.Controllers
{
    public class JobAssignmentController : Controller
    {
        private readonly AppDbContext _context;

        public JobAssignmentController(AppDbContext context)
        {
            _context = context;
        }

        //// GET: HolidayRequist
        public IActionResult Index()
        {
            IEnumerable<JobAssignment> objList = _context.JobAssignments;
            return View(objList);
        }

        ////GET - CREATE
        public IActionResult Create(string query = null)
        {
            // ViewBag.EmployeeId = new SelectList(_context.Employees, "Id", "Id");
            //var EmployeeQuery = _context.Hr_Employees
            //     .Include(x => x.NameEmp);
            //if (!string.IsNullOrWhiteSpace(query))
            //    EmployeeQuery=EmployeeQuery.Where(x=>x.NameEmp.Contains(query));

            //var EmployeeDtos = EmployeeQuery

            //    .ToList()
            //    .Select(JobAssignment.Name < JobAssignment, EmployeeDtos)
            return View();
            //return View(EmployeeDtos);
        }


        //////POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(JobAssignment obj)
        {
            if (ModelState.IsValid)
            {
                _context.JobAssignments.Add(obj);
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
            var obj = _context.JobAssignments.Find(id);
           

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(JobAssignment obj)
        {
            if (ModelState.IsValid)
            {
                _context.JobAssignments.Update(obj);
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
            var obj = _context.JobAssignments.Find(id);
            

            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _context.JobAssignments.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.JobAssignments.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }

    }
}
