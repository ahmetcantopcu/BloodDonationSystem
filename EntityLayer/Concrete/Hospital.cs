using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hospital
    {
        [Key]
        public int HospitalID { get; set; }
        public string HospitalName { get; set; }
        public string HospitalCity { get; set; }
        public bool HospitalStatus { get; set; }
        public List<Donation> Donations { get; set; }
    }
}
