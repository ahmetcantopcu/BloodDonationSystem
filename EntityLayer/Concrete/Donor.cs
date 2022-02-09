using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Donor
    {
        [Key]
        public int DonorID { get; set; }
        public string DonorName { get; set; }
        public string DonorAbout { get; set; }
        public string DonorImage { get; set; }
        public int DonorAge { get; set; }
        public string DonorSex { get; set; }
        public string DonorMail { get; set; }
        public string DonorPassword { get; set; }
        public string DonorAddress { get; set; }
        public bool DonorStatus { get; set; }        
        public int BloodID { get; set; }
        public Blood Blood { get; set; }
        public List<Evaluation> Evaluations { get; set; }
        public List<Donation> Donations { get; set; }

    }
}
