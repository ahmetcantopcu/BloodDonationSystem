using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationSystem.ViewComponents.Donor
{
    public class DonorAboutOnDashboard : ViewComponent
    {
        DonorManager dm = new DonorManager(new EfDonorRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;          
            var donorID = c.Donors.Where(x => x.DonorMail == usermail).Select(y => y.DonorID).FirstOrDefault();
            var values = dm.GetDonorById(donorID);
            return View(values);
        }
    }
}
