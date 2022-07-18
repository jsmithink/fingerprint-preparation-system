using fb.Models.Data;
using fb.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace fb.Controllers
{
    public class TypeExemptionController : Controller
    {
        private readonly AppDbContext _context;

        public TypeExemptionController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Discount
        public IActionResult Index()
        {
            IEnumerable<TypeExemption> objList = _context.TypeExemptions;
            return View(objList);
        }

        ////GET - CREATE
        public IActionResult Create()
        {
            ViewBag.ExemptionId = new SelectList(_context.Exemptions, "Id", "Id");
           
            return View();
        }


        //////POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TypeExemption obj)
        {
            if (ModelState.IsValid)
            {
                _context.TypeExemptions.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //////GET - EDIT
        public IActionResult Edit(int? id)
        {
            ViewBag.ExemptionId = new SelectList(_context.Exemptions, "Id", "Id");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.TypeExemptions.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TypeExemption obj)
        {
            if (ModelState.IsValid)
            {
                _context.TypeExemptions.Update(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            ViewBag.ExemptionId = new SelectList(_context.Exemptions, "Id", "Id");
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _context.TypeExemptions.Find(id);
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
            var obj = _context.TypeExemptions.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _context.TypeExemptions.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }

    }


