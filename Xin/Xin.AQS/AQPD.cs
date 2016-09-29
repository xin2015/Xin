using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xin.AQS.AQE;

namespace Xin.AQS
{
    public class AQRPD : HourAQICalculate
    {
        public string Code { get; set; }
        public DateTime Time { get; set; }
    }

    public class AQDPD : DayAQICalculate
    {
        public string Code { get; set; }
        public DateTime Time { get; set; }
    }
}
