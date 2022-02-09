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
    public class HospitalManager : IHospitalService
    {
        IHospitalDal _hospitaldal;

        public HospitalManager(IHospitalDal hospitaldal)
        {
            _hospitaldal = hospitaldal;
        }

        public Hospital GetByID(int id)
        {
            return _hospitaldal.GetByID(id);
        }

        public List<Hospital> GetList()
        {
            return _hospitaldal.GetListAll();
        }
    }
}
