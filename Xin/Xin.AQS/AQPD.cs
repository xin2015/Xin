using System;
using Widgets.AQE;

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
