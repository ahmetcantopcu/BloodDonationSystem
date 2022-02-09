﻿ using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Donation
    {
        [Key]
        public int DonationID { get; set; }
        public DateTime DonationDate { get; set; }    
        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }    
        public int DonorID { get; set; }
        public Donor Donor { get; set; }



    }
}
