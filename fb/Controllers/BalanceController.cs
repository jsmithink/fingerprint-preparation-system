using Microsoft.AspNetCore.Mvc;
using fb.Models.Data;
using System.Collections.Generic;
using fb.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace fb.Controllers
{
    public class BalanceController : Controller
    {
        private readonly AppDbContext _context;

        public BalanceController(AppDbContext context)
        {
            _context = context;
        }

        //// GET: Balance
        public IActionResult Index()
        {
            IEnumerable<Balance> objList = _context.Balances;
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
        public IActionResult Create(Balance obj)
        {
            if (ModelState.IsValid)
            {
                _context.Balances.Add(obj);
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
            var obj = _context.Balances.Find(id);
           

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Balance obj)
        {
            if (ModelState.IsValid)
            {
                _context.Balances.Update(obj);
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
            var obj = _context.Balances.Find(id);
            

            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _context.Balances.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.Balances.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");




        }

    }
}
