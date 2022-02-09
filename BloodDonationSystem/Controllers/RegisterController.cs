using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationSystem.Controllers
{
    public class RegisterController : Controller
    {
        DonorManager dm = new DonorManager(new EfDonorRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Donor p)
        {
            DonorValidator dv = new DonorValidator();
            ValidationResult result = dv.Validate(p);
            if (result.IsValid)
            {
                p.DonorStatus = true;
                p.DonorAbout = "Deneme Test";
               // p.DonationID = 1;
                p.BloodID = 1;              
                dm.TAdd(p);
                return RedirectToAction("Index", "Evaluation");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
