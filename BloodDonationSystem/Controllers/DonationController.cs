using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationSystem.Controllers
{
    public class DonationController : Controller
    {
        Context c = new Context();
        DonationManager dm = new DonationManager(new EfDonationRepository());
        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Donation p)
        {
            var usermail = User.Identity.Name;
            var donorID = c.Donors.Where(x => x.DonorMail == usermail).Select(y => y.DonorID).FirstOrDefault();
            p.HospitalID = 3;
           // p.BloodID = 1;
            p.DonorID = donorID;
            dm.DonationAdd(p);
            return RedirectToAction("Index","Evaluation");
        }
    }
}
