using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EvaluationManager : IEvaluationService
    {
        IEvaluationDal _evaluationDal;

        public EvaluationManager(IEvaluationDal evaluationDal)
        {
            _evaluationDal = evaluationDal;
        }

        //public void EvaluationAdd(Evaluation evaluation)
        //{
        //    _evaluationDal.Insert(evaluation);
        //}

        //public void EvaluationDelete(Evaluation evaluation)
        //{
        //    _evaluationDal.Delete(evaluation);
        //}

        //public void EvaluationUpdate(Evaluation evaluation)
        //{
        //    _evaluationDal.Update(evaluation);
        //}

        public Evaluation TGetByID(int id)
        {
            return _evaluationDal.GetByID(id);
        }
        public List<Evaluation> GetEvaluationByID(int id)
        {
            return _evaluationDal.GetListAll(x => x.EvaluationID == id);
        }

        public List<Evaluation> GetEvaluationListByDonor(int id)
        {
            return _evaluationDal.GetListAll(x=>x.DonorID==id);
        }

        public List<Evaluation> GetList()
        {
            return _evaluationDal.GetListAll();
        }
        public List<Evaluation> GetLast3Evaluation()
        {
            return _evaluationDal.GetListAll().Take(3).ToList();
        }

        public void TAdd(Evaluation t)
        {
            _evaluationDal.Insert(t);
        }

        public void TDelete(Evaluation t)
        {
            _evaluationDal.Delete(t);
        }

        public void TUpdate(Evaluation t)
        {
            _evaluationDal.Update(t);
        }     
    }
}
