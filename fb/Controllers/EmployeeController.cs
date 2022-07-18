using fb.Models.Data;
using fb.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace fb.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        //// GET: Balance
        public IActionResult Index()
        {
            IEnumerable<Employee> objList = _context.Employees;
            return View(objList);
        }

        ////GET - CREATE
        public IActionResult Create()
        {
            ViewBag.ShiftId = new SelectList(_context.Shifts, "Id", "Name");
            ViewBag.BalanceId = new SelectList(_context.Balances, "Id", "Id");
           ViewBag.DiscountId = new SelectList(_context.Discounts, "ID", "ID");
            


            //ViewData["ShiftId"] = new SelectList(_context.Shifts, "Id", "Id");
            //ViewData["BalanceId"] = new SelectList(_context.Balances, "Id", "Id");
            //ViewData["DiscountId"] = new SelectList(_context.Discounts, "Id", "Id");
            return View();
        }


        //////POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee obj)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //////GET - EDIT
        public IActionResult Edit(int? id)
        {
            ViewBag.ShiftId = new SelectList(_context.Shifts, "Id", "Name");
            ViewBag.BalanceId = new SelectList(_context.Balances, "Id", "Id");
            ViewBag.DiscountId = new SelectList(_context.Discounts, "ID", "ID");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.Employees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee obj)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Update(obj);
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
            var obj = _context.Employees.Find(id);
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
            var obj = _context.Employees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.Employees.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }

    }
}
