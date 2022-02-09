using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
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
    public class EvaluationController : Controller
    {
        
        EvaluationManager em = new EvaluationManager(new EfEvaluationRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            var values = em.GetList();
            return View(values);
        }
        public IActionResult EvaluationReadAll(int id)
        {
            ViewBag.i = id;
            var values = em.GetEvaluationByID(id);
            return View(values);
        }

        public IActionResult EvaluationListByDonor()
        {           
            var usermail = User.Identity.Name;
            var donorID = c.Donors.Where(x => x.DonorMail == usermail).Select(y => y.DonorID).FirstOrDefault();
            var values=em.GetEvaluationListByDonor(donorID);
            return View(values);
        }
        [HttpGet]
        public IActionResult EvaluationAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EvaluationAdd(Evaluation p)
        {
            var usermail = User.Identity.Name;
            var donorID = c.Donors.Where(x => x.DonorMail == usermail).Select(y => y.DonorID).FirstOrDefault();
            EvaluationValidator ev = new EvaluationValidator();
            ValidationResult result = ev.Validate(p);
            if (result.IsValid)
            {
                p.EvaluationStatus = true;
                p.EvaluationCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.DonorID = donorID;
                em.TAdd(p);
                return RedirectToAction("EvaluationListByDonor", "Evaluation");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteEvaluation(int id)
        {
            var evaluationvalue = em.TGetByID(id);
            em.TDelete(evaluationvalue);
            return RedirectToAction("EvaluationListByDonor");
        }

        [HttpGet]
        public IActionResult EditEvaluation(int id)
        {
            var evaluationvalue = em.TGetByID(id);
            return View(evaluationvalue);
        }
        [HttpPost]
        public IActionResult EditEvaluation(Evaluation p)
        {          
            var usermail = User.Identity.Name;
            var donorID = c.Donors.Where(x => x.DonorMail == usermail).Select(y => y.DonorID).FirstOrDefault();
            p.DonorID = donorID;
            p.EvaluationCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.EvaluationStatus = true;
            em.TUpdate(p);
            return RedirectToAction("EvaluationListByDonor");
        }
    }
}
