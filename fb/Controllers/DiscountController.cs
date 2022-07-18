using fb.Models.Data;
using fb.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace fb.Controllers
{
    public class DiscountController : Controller
    {
        private readonly AppDbContext _context;

        public DiscountController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Discount
        public IActionResult Index()
        {
            IEnumerable<Discount> objList = _context.Discounts;
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
        public IActionResult Create(Discount obj)
        {
            if (ModelState.IsValid)
            {
                _context.Discounts.Add(obj);
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
            var obj = _context.Discounts.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Discount obj)
        {
            if (ModelState.IsValid)
            {
                _context.Discounts.Update(obj);
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
            var obj = _context.Discounts.Find(id);
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
            var obj = _context.Discounts.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.Discounts.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }

    }


