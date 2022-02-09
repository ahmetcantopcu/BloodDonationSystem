using BloodDonationSystem.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationSystem.Controllers
{  
    public class DonorController : Controller
    {
        DonorManager dm = new DonorManager(new EfDonorRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;         
            var donorname = c.Donors.Where(x => x.DonorMail == usermail).Select(y => y.DonorName).FirstOrDefault();
            ViewBag.v2 = donorname;
            return View();
        }
        public IActionResult DonorProfile()
        {
            return View();
        }
        public IActionResult DonorMail()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult DonorNavbarPartial()
        {
            var usermail = User.Identity.Name;
            var donorID = c.Donors.Where(x => x.DonorMail == usermail).Select(y => y.DonorID).FirstOrDefault();
            var donorvalues = dm.TGetByID(donorID);
            return PartialView(donorvalues);
        }
        [AllowAnonymous]
        public PartialViewResult DonorFooterPartial()
        {
            return PartialView();
        }
        
        [HttpGet]

        public IActionResult DonorEditProfile()
        {
            
            var usermail = User.Identity.Name;
            var donorID = c.Donors.Where(x => x.DonorMail == usermail).Select(y => y.DonorID).FirstOrDefault();
            var donorvalues = dm.TGetByID(donorID);
            return View(donorvalues);
        }
       
        [HttpPost]
        public IActionResult DonorEditProfile(Donor p)
        {
            DonorValidator dv = new DonorValidator();
            ValidationResult results = dv.Validate(p);
            p.BloodID = 1;
            if (results.IsValid)
            {
                dm.TUpdate(p);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult DonorAdd()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult DonorAdd(AddProfileImage p) //Take the picture from donor.
        {
            Donor d = new Donor();
            if (p.DonorImage != null)
            {
                var extension = Path.GetExtension(p.DonorImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/DonorImageFiles/",newimagename);
                var stream = new FileStream(location,FileMode.Create);
                p.DonorImage.CopyTo(stream);
                d.DonorImage = newimagename;
            }
            d.DonorMail = p.DonorMail;
            d.DonorName = p.DonorName;
            d.DonorPassword = p.DonorPassword;
            d.DonorStatus = true;
            d.DonorAbout = p.DonorAbout;
            dm.TAdd(d);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
