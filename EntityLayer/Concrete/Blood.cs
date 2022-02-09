using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Blood
    {
        [Key]
        public int BloodID { get; set; }
        public string BloodType { get; set; }
        public int BloodStock { get; set; }
        public List<Donor> Donors { get; set; }
       
    }
}
