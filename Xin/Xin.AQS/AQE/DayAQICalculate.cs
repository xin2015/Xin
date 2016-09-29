using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.AQS.AQE
{
    /// <summary>
    /// 日均空气质量指数（计算）
    /// </summary>
    public class DayAQICalculate : IAQICalculate
    {
        /// <summary>
        /// 二氧化硫（SO2）24小时平均浓度（μg/m³）
        /// </summary>
        public decimal? SO2 { get; set; }
        /// <summary>
        /// 二氧化氮（NO2）24小时平均浓度（μg/m³）
        /// </summary>
        public decimal? NO2 { get; set; }
        /// <summary>
        /// 颗粒物（粒径小于等于10μm）24小时平均浓度（μg/m³）
        /// </summary>
        public decimal? PM10 { get; set; }
        /// <summary>
        /// 一氧化碳（CO）24小时平均浓度（mg/m³）
        /// </summary>
        public decimal? CO { get; set; }
        /// <summary>
        /// 臭氧（O3）最大8小时滑动平均浓度（μg/m³）
        /// </summary>
        public decimal? O3 { get; set; }
        /// <summary>
        /// 颗粒物（粒径小于等于2.5μm）24小时平均浓度（μg/m³）
        /// </summary>
        public decimal? PM25 { get; set; }
        /// <summary>
        /// 空气质量指数
        /// </summary>
        public int? AQI { get; set; }
        /// <summary>
        /// 首要污染物
        /// </summary>
        public string PrimaryPollutant { get; set; }
        /// <summary>
        /// 空气质量指数类别
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 计算空气质量指数
        /// </summary>
        public virtual void CalculateAQI()
        {
            AQIHelper.CalculateDayAQI(this);
        }
    }
}
