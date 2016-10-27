using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.WindowsFormsApplication
{
    public class NMCMeteorologyMonitorData
    {
        public string CityCode { get; set; }
        public DateTime TimePoint { get; set; }
        public DateTime CreateTime { get; set; }
        public decimal? WindDirection { get; set; }
        public decimal? WindSpeed { get; set; }
        public decimal? Pressure { get; set; }
        public decimal? AirTemperature { get; set; }
        public decimal? Humidity { get; set; }
        public decimal? Rainfall { get; set; }
        public decimal? Apparent { get; set; }
    }
}
