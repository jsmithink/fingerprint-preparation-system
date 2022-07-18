using fb.Models.Data;
using fb.Models.Entites;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using fb.Interfaces;

namespace Fingerprint.Repositories
{
    public class FingerprintDevicesRepository : IFingerprintDevices
    {
        private readonly AppDbContext _context;
        public FingerprintDevicesRepository (AppDbContext context)
        {
            _context = context;

        }

        // filtiring search
        public List<FingerprintDevices> GetItems()
        {
            List<FingerprintDevices> fingerprintDevices=_context.FingerprintDevices.ToList();
            return fingerprintDevices;
        }

        /// 
        public FingerprintDevices Create(FingerprintDevices fingerprintDevices)
        {
            _context.FingerprintDevices.Add(fingerprintDevices);
            _context.SaveChanges();
            return fingerprintDevices;
        }

        public FingerprintDevices Delete(FingerprintDevices fingerprintDevices)
        {
            _context.FingerprintDevices.Attach(fingerprintDevices);
            _context.Entry(fingerprintDevices).State = EntityState.Deleted;
            _context.SaveChanges();
            return fingerprintDevices;
        }

        public FingerprintDevices Edit(FingerprintDevices fingerprintDevices)
        {
            _context.FingerprintDevices.Attach(fingerprintDevices);
            _context.Entry(fingerprintDevices).State = EntityState.Modified;
            _context.SaveChanges();
            return fingerprintDevices;
        }

        public FingerprintDevices GetFingerprintDevices(int id)
        {
            FingerprintDevices fingerprintDevices = _context.FingerprintDevices.Where(f => f.Id == id).FirstOrDefault();
            return fingerprintDevices;
        }

       //////// SEARCH 
       
        public List<FingerprintDevices> Search(string term)
        {
            var result=_context.FingerprintDevices.Where(d=>d.Device_Name.Contains(term)
                       ||d.Site_Device.Contains(term)
                       ||d.Device_Number.ToString().Contains(term)).ToList();
            return result;
        }


    }
}
