using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationSystem.Controllers
{
    public class BloodController : Controller
    {
        BloodManager bm = new BloodManager(new EfBloodRepository());
        public IActionResult Index()
        {
            var values = bm.GetList();
            return View(values);
        }
    }
}
