using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.AQS.AQE
{
    /// <summary>
    /// 空气质量指数计算接口
    /// </summary>
    public interface IAQICalculate : IAirData
    {
        /// <summary>
        /// 空气质量指数
        /// </summary>
        int? AQI { get; set; }
        /// <summary>
        /// 首要污染物
        /// </summary>
        string PrimaryPollutant { get; set; }
        /// <summary>
        /// 空气质量指数类别
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// 计算空气质量指数
        /// </summary>
        void CalculateAQI();
    }
}
