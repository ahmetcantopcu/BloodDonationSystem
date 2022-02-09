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
    public class BloodManager : IBloodService
    {
        IBloodDal _bloodDal;

        public BloodManager(IBloodDal bloodDal)
        {
            this._bloodDal = bloodDal;
        }    
        public Blood TGetByID(int id)
        {
            return _bloodDal.GetByID(id);
        }

        public List<Blood> GetList()
        {
            return _bloodDal.GetListAll();
        }

        public void TAdd(Blood t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Blood t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Blood t)
        {
            throw new NotImplementedException();
        }
    }
}
