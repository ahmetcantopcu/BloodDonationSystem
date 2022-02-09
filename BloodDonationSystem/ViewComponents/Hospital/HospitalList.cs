using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationSystem.ViewComponents.Hospital
{
    public class HospitalList : ViewComponent
    {
        HospitalManager hm = new HospitalManager(new EfHospitalRepository());
        public IViewComponentResult Invoke()
        {
            var values = hm.GetList();
            return View(values);
        }
    }
}
