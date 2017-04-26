using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.WebApiDoc.Models
{
    public class ApiDescriptionEntity
    {
        public String HttpMethod { get; set; }
        public String Url { get; set; }
        public String FullMethodAddr { get; set; }
    }
}
