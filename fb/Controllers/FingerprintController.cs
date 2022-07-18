//using Microsoft.AspNetCore.Mvc;
//using fb.Models.Data;
//using System.Collections.Generic;
//using fb.Models.Entites;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Mvc.Rendering;

//namespace fb.Controllers
//{
//    public class FingerprintController : Controller
//    {
//        private readonly AppDbContext _context;

//        public FingerprintController(AppDbContext context)
//        {
//            _context = context;
//        }

//        //// GET: Balance
//        public IActionResult Index()
//        {
//            IEnumerable<Fingerprint> objList = _context.Fingerprints;
//            return View(objList);
//        }

//        ////GET - CREATE
//        public IActionResult Create()
//        {
//            ViewBag.EmployeeId = new SelectList(_context.Employees, "Id", "Id");
//            ViewBag.FingerprintDevicesId = new SelectList(_context.FingerprintDevices, "Id", "Id");
//            return View();
//        }


//        //////POST - CREATE
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Create(Fingerprint obj)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Fingerprints.Add(obj);
//                _context.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(obj);

//        }


//        //////GET - EDIT
//        public IActionResult Edit(int? id)
//        {
//            ViewBag.EmployeeId = new SelectList(_context.Employees, "Id", "Id");
//            ViewBag.FingerprintDevicesId = new SelectList(_context.FingerprintDevices, "Id", "Id");
//            if (id == null || id == 0)
//            {
//                return NotFound();
//            }
//            var obj = _context.Fingerprints.Find(id);
//            if (obj == null)
//            {
//                return NotFound();
//            }

//            return View(obj);
//        }

//        //POST - EDIT
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Edit(Fingerprint obj)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Fingerprints.Update(obj);
//                _context.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(obj);

//        }

//        //GET - DELETE
//        public IActionResult Delete(int? id)
//        {
//            ViewBag.EmployeeId = new SelectList(_context.Employees,"Id", "Id");
//            ViewBag.FingerprintDevicesId = new SelectList(_context.FingerprintDevices,"Id", "Id");
//            if (id == null || id == 0)
//            {
//                return NotFound();
//            }
//            var obj = _context.Fingerprints.Find(id);
//            if (obj == null)
//            {
//                return NotFound();
//            }

//            return View(obj);
//        }

//        //POST - DELETE
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult DeletePost(int? id)
//        {
//            var obj = _context.Fingerprints.Find(id);
//            if (obj == null)
//            {
//                return NotFound();
//            }
//            _context.Fingerprints.Remove(obj);
//            _context.SaveChanges();
//            return RedirectToAction("Index");




//        }

//    }
//}
