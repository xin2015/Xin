using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.AQS.AQE
{
    /// <summary>
    /// 综合质量指数报表接口
    /// </summary>
    public interface IAQCIReport : IAQCICalculate
    {
        /// <summary>
        /// 二氧化硫（SO2）单项质量指数
        /// </summary>
        decimal? ISO2 { get; set; }
        /// <summary>
        /// 二氧化氮（NO2）单项质量指数
        /// </summary>
        decimal? INO2 { get; set; }
        /// <summary>
        /// 颗粒物（粒径小于等于10μm）单项质量指数
        /// </summary>
        decimal? IPM10 { get; set; }
        /// <summary>
        /// 颗粒物（粒径小于等于2.5μm）单项质量指数
        /// </summary>
        decimal? IPM25 { get; set; }
        /// <summary>
        /// 一氧化碳（CO）单项质量指数
        /// </summary>
        decimal? ICO { get; set; }
        /// <summary>
        /// 臭氧（O3）单项质量指数
        /// </summary>
        decimal? IO3 { get; set; }

        /// <summary>
        /// 计算单项质量指数
        /// </summary>
        void CalculateIAQCI();

        /// <summary>
        /// 计算综合质量指数报表
        /// </summary>
        void CalculateAQCIReport();
    }
}
