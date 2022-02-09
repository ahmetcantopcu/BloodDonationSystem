using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BloodDonationSystem.Controllers
{
    public class LoginController : Controller
    {
      //  Context c = new Context();
       
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Donor p)
        {
            Context c = new Context();
            var datavalue = c.Donors.FirstOrDefault(x => x.DonorMail == p.DonorMail && x.DonorPassword == p.DonorPassword);
            HttpContext.Session.SetString("fullname", datavalue.DonorName);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.DonorMail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Evaluation");
            }
            else
            {
                return View();
            }
        }
    }
}

