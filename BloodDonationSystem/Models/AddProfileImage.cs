using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonationSystem.Models
{
    public class AddProfileImage
    {
        public int DonorID { get; set; }
        public string DonorName { get; set; }
        public string DonorAbout { get; set; }
        public IFormFile DonorImage { get; set; }
        public int DonorAge { get; set; }
        public string DonorSex { get; set; }
        public string DonorMail { get; set; }
        public string DonorPassword { get; set; }
        public string DonorAddress { get; set; }
        public bool DonorStatus { get; set; }
    }
}
