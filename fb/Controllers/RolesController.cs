using Microsoft.AspNetCore.Mvc;
using fb.Models.Data;
using System.Collections.Generic;
using fb.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace fb.Controllers
{
    public class RolesController : Controller
    {
        private readonly AppDbContext _context;

        public RolesController(AppDbContext context)
        {
            _context = context;
        }

        //// GET: Balance
        public IActionResult Index()
        {
            IEnumerable<Roles> objList = _context.Roles;
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
        public IActionResult Create(Roles obj)
        {
            if (ModelState.IsValid)
            {
                _context.Roles.Add(obj);
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
            var obj = _context.Roles.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Roles obj)
        {
            if (ModelState.IsValid)
            {
                _context.Roles.Update(obj);
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
            var obj = _context.Roles.Find(id);
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
            var obj = _context.Roles.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.Roles.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }

    }
}
