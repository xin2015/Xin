using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.AQS.AQE
{
    /// <summary>
    /// 综合质量指数计算接口
    /// </summary>
    public interface IAQCICalculate : IAirData
    {
        /// <summary>
        /// 综合质量总数
        /// </summary>
        decimal? AQCI { get; set; }
        /// <summary>
        /// 最大质量指数
        /// </summary>
        decimal? AQMI { get; set; }
        /// <summary>
        /// 首要污染物
        /// </summary>
        string PrimaryPollutant { get; set; }

        /// <summary>
        /// 计算综合质量指数
        /// </summary>
        void CalculateAQCI();
    }
}
