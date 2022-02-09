using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EvaluationLegibility
    {
        public int EvaluationLegibilityID { get; set; }
        public int EvaluationID { get; set; }
        public int EvaluationTotalScore { get; set; }
        public int EvaluationLegibilityCount { get; set; }
    }
}
