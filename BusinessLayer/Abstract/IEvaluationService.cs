using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEvaluationService : IGenericService<Evaluation>
    {
        //void EvaluationAdd(Evaluation evaluation);
        //void EvaluationDelete(Evaluation evaluation);
        //void EvaluationUpdate(Evaluation evaluation);
        //List<Evaluation> GetList();
        //Evaluation GetByID(int id);
        List<Evaluation> GetEvaluationListByDonor(int id);
    }
}
