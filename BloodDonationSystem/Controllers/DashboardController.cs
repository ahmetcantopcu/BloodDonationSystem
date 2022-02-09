using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationSystem.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            var donorID = c.Donors.Where(x => x.DonorMail == usermail).Select(y => y.DonorID).FirstOrDefault();
            ViewBag.value = c.Evaluations.Count().ToString();
            ViewBag.value2 = c.Evaluations.Where(x => x.DonorID == donorID).Count();
            return View();
        }
    }
}
