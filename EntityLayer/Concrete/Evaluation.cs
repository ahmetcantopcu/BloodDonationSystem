using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Evaluation
    {
        [Key]
        public int EvaluationID { get; set; }
        public string EvaluationTitle { get; set; }
        public string EvaluationContent { get; set; }
        public string EvaluationThumbNailImage { get; set; }
        public string EvaluationImage { get; set; }
        public DateTime EvaluationCreateDate { get; set; }
        public bool EvaluationStatus { get; set; }
        public int DonorID { get; set; }
        public Donor Donor { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
