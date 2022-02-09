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
    public class DonorManager : IDonorService
    {
        IDonorDal _donordal;

        public DonorManager(IDonorDal donordal)
        {
            _donordal = donordal;
        }

        public List<Donor> GetDonorById(int id)
        {
            return _donordal.GetListAll(x => x.DonorID == id);
        }

        public List<Donor> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Donor t)
        {
            _donordal.Insert(t);
        }

        public void TDelete(Donor t)
        {
            throw new NotImplementedException();
        }

        public Donor TGetByID(int id)
        {
            return _donordal.GetByID(id);
        }

        public void TUpdate(Donor t)
        {
            _donordal.Update(t);
        }
    }
}
