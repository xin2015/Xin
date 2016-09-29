using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.AQS.AQE
{
    /// <summary>
    /// 空气质量综合指数计算类
    /// </summary>
    public class AQCICalculate : IAQCICalculate
    {
        /// <summary>
        /// 二氧化硫（SO2）24小时平均浓度均值（μg/m³）
        /// </summary>
        public decimal? SO2 { get; set; }
        /// <summary>
        /// 二氧化氮（NO2）24小时平均浓度均值（μg/m³）
        /// </summary>
        public decimal? NO2 { get; set; }
        /// <summary>
        /// 颗粒物（粒径小于等于10μm）24小时平均浓度均值（μg/m³）
        /// </summary>
        public decimal? PM10 { get; set; }
        /// <summary>
        /// 颗粒物（粒径小于等于2.5μm）24小时平均浓度均值（μg/m³）
        /// </summary>
        public decimal? PM25 { get; set; }
        /// <summary>
        /// 一氧化碳（CO）24小时平均浓度第95百分位数（mg/m³）
        /// </summary>
        public decimal? CO { get; set; }
        /// <summary>
        /// 臭氧（O3）最大8小时滑动平均浓度第90百分位数（μg/m³）
        /// </summary>
        public decimal? O3 { get; set; }
        /// <summary>
        /// 空气质量综合指数
        /// </summary>
        public decimal? AQCI { get; set; }
        /// <summary>
        /// 最大质量指数
        /// </summary>
        public decimal? AQMI { get; set; }
        /// <summary>
        /// 首要污染物
        /// </summary>
        public string PrimaryPollutant { get; set; }

        /// <summary>
        /// 计算空气质量综合指数
        /// </summary>
        public virtual void CalculateAQCI()
        {
            AQCIHelper.CalculateAQCI(this);
        }
    }
}
