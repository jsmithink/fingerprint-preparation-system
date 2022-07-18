using fb.Models;
using fb.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using fb.Interfaces;

namespace Fingerprint.Controllers
{
    public class FingerprintDevicesController : Controller
    {
       // private IRepository<User> users;
        
        private readonly IFingerprintDevices _fingerprintDevicesRepo;
        public FingerprintDevicesController(IFingerprintDevices fingerprintDevicesRepo) 
        { 
            _fingerprintDevicesRepo = fingerprintDevicesRepo;
          
        }



        // GET: FingerprintDevicesController
        public ActionResult Index(int page = 1)
        {
            List<FingerprintDevices> fingerprintDevices = _fingerprintDevicesRepo.GetItems();
            const int pageSize = 10;
            if (page < 1)
                page = 1;
            int Count = fingerprintDevices.Count();
            var pagingInfo = new PagingInfo(Count, page, pageSize);
            pagingInfo.PageName = "FingerprintDevices";
            int recSkip = (page - 1) * pageSize;
            var data = fingerprintDevices.Skip(recSkip).Take(pagingInfo.ItemsPerPage).ToList();
            this.ViewBag.PagingInfo = pagingInfo;
            return View(data);

          
            //return View(fingerprintDevices);

        }

        ////GET - CREATE
        public IActionResult Create()
        {
            FingerprintDevices fingerprintDevices = new FingerprintDevices();
            return View(fingerprintDevices);
        }


        //////POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FingerprintDevices fingerprintDevices)
        {
            try
            {
                fingerprintDevices = _fingerprintDevicesRepo.Create(fingerprintDevices);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));
         
        }

        // // // Details method
        public IActionResult Details(int Id)
        {
            FingerprintDevices fingerprintDevices= _fingerprintDevicesRepo.GetFingerprintDevices(Id);
            return View(fingerprintDevices);
        }

       


        //////GET - EDIT
        public IActionResult Edit(int id)
        {
            FingerprintDevices fingerprintDevices = _fingerprintDevicesRepo.GetFingerprintDevices(id);

            return View(fingerprintDevices);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(FingerprintDevices fingerprintDevices)
        {
            try
            {
                fingerprintDevices = _fingerprintDevicesRepo.Edit(fingerprintDevices);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));


        }

        //GET - DELETE
        public IActionResult Delete(int id)
        {
            FingerprintDevices fingerprintDevices = _fingerprintDevicesRepo.GetFingerprintDevices(id);

            return View(fingerprintDevices);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(FingerprintDevices fingerprintDevices)
        {
            try
            {
                fingerprintDevices = _fingerprintDevicesRepo.Delete(fingerprintDevices);
            }
            catch
            {

            }
            return RedirectToAction(nameof(Index));



        }
        public ActionResult Search(string term)
        {
            var result= _fingerprintDevicesRepo.Search(term);
            return View("Index",result);
        }
     
    }
   
}
