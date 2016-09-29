using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.AQS.AQE
{
    /// <summary>
    /// 空气质量指数详细结果接口
    /// </summary>
    public interface IAQIResult : IAQIReport
    {
        /// <summary>
        /// 对健康影响情况
        /// </summary>
        string Effect { get; set; }
        /// <summary>
        /// 建议采取的措施
        /// </summary>
        string Measure { get; set; }
        /// <summary>
        /// 超标污染物
        /// </summary>
        string NonAttainmentPollutant { get; set; }

        /// <summary>
        /// 计算对健康影响情况和建议采取的措施
        /// </summary>
        void CalculateEffectAndMeasure();

        /// <summary>
        /// 计算超标污染物
        /// </summary>
        void CalculateNonAttainmentPollutant();

        /// <summary>
        /// 计算空气质量指数详细结果
        /// </summary>
        void CalculateAQIResult();
    }
}
