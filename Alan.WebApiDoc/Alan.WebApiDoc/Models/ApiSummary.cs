using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Models
{
    public class ApiSummary
    {
        public String Summary { get; set; }
        public String Example { get; set; }
        public String Url { get; set; }
        public String HttpMethod { get; set; }
        public List<ApiParameterSummary> InputParameters { get; set; }
        public List<ApiParameterSummary> OutputParameters { get; set; }
    }
}
