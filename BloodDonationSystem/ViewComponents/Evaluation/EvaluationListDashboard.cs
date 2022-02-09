using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationSystem.ViewComponents.Evaluation
{
    public class EvaluationListDashboard : ViewComponent
    {
        EvaluationManager em = new EvaluationManager(new EfEvaluationRepository());
        public IViewComponentResult Invoke()
        {
            var values = em.GetList();
            return View(values);
        }
    }
}
