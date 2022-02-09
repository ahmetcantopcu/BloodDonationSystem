using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHospitalService
    {
      //  void HospitalAdd(Hospital hospital);
      //  void HospitalDelete(Hospital hospital);
     //   void HospitalUpdate(Hospital hospital);
        List<Hospital> GetList();
        Hospital GetByID(int id);
    }
}
