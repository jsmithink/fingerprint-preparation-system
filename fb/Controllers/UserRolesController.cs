using Microsoft.AspNetCore.Mvc;
using fb.Models.Data;
using System.Collections.Generic;
using fb.Models.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace fb.Controllers
{
    public class UserRolesController : Controller
    {
        private readonly AppDbContext _context;

        public UserRolesController(AppDbContext context)
        {
            _context = context;
        }

        //// GET: UserRoles
        public IActionResult Index()
        {
            IEnumerable<UserRoles> objList = _context.UserRoles;
            return View(objList);
        }

        ////GET - CREATE
        public IActionResult Create()
        {
            ViewBag.EmployeeId = new SelectList(_context.Employees, "Id","Id");
            ViewBag.RolesId = new SelectList(_context.Roles, "Id", "Id");
            return View();
        }


        //////POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserRoles obj)
        {
            if (ModelState.IsValid)
            {
                _context.UserRoles.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //////GET - EDIT
        public IActionResult Edit(int? id)
        {
            ViewBag.EmployeeId = new SelectList(_context.Employees, "Id", "Id");
            ViewBag.RolesId = new SelectList(_context.Roles, "Id", "Id");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.UserRoles.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UserRoles obj)
        {
            if (ModelState.IsValid)
            {
                _context.UserRoles.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            ViewBag.EmployeeId = new SelectList(_context.Employees, "Id", "Id");
            ViewBag.RolesId = new SelectList(_context.Roles, "Id", "Id");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.UserRoles.Find(id);
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
            var obj = _context.UserRoles.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.UserRoles.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }

    }
}
