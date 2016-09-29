using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.AQS.AQE
{
    /// <summary>
    /// 空气质量指数日报/实时报接口
    /// </summary>
    public interface IAQIReport : IAQICalculate
    {
        /// <summary>
        /// 二氧化硫（SO2）平均分指数
        /// </summary>
        int? ISO2 { get; set; }
        /// <summary>
        /// 二氧化氮（NO2）平均分指数
        /// </summary>
        int? INO2 { get; set; }
        /// <summary>
        /// 颗粒物（粒径小于等于10μm）平均分指数
        /// </summary>
        int? IPM10 { get; set; }
        /// <summary>
        /// 一氧化碳（CO）平均分指数
        /// </summary>
        int? ICO { get; set; }
        /// <summary>
        /// 臭氧（O3）平均分指数
        /// </summary>
        int? IO3 { get; set; }
        /// <summary>
        /// 颗粒物（粒径小于等于2.5μm）平均分指数
        /// </summary>
        int? IPM25 { get; set; }
        /// <summary>
        /// 空气质量指数级别
        /// </summary>
        string Level { get; set; }
        /// <summary>
        /// 空气质量指数类别颜色
        /// </summary>
        string Color { get; set; }

        /// <summary>
        /// 计算空气质量分指数
        /// </summary>
        void CalculateIAQI();

        /// <summary>
        /// 计算AQI相关
        /// </summary>
        void CalculateAQIAbout();

        /// <summary>
        /// 计算空气质量指数日报/实时报
        /// </summary>
        void CalculateAQIReport();
    }
}
