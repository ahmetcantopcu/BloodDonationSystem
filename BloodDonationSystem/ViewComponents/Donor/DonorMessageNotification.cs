using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationSystem.ViewComponents.Donor
{
    public class DonorMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {           
            return View();
        }
    }
}
