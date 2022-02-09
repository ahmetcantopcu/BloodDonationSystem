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
    public class DonationManager : IDonationService
    {
        IDonationDal _donationDal;

        public DonationManager(IDonationDal donationDal)
        {
            _donationDal = donationDal;
        }

        public void DonationAdd(Donation donation)
        {
            _donationDal.Insert(donation);
        }
    }
}
