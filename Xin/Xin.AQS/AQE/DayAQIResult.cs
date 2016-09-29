using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.AQS.AQE
{
    /// <summary>
    /// 空气质量指数详细结果
    /// </summary>
    public class DayAQIResult : DayAQIReport, IAQIResult
    {
        /// <summary>
        /// 对健康影响情况
        /// </summary>
        public string Effect { get; set; }
        /// <summary>
        /// 建议采取的措施
        /// </summary>
        public string Measure { get; set; }
        /// <summary>
        /// 超标污染物
        /// </summary>
        public string NonAttainmentPollutant { get; set; }

        /// <summary>
        /// 计算对健康影响情况和建议采取的措施（需要已经先计算好空气质量指数类别）
        /// </summary>
        public virtual void CalculateEffectAndMeasure()
        {
            AQIHelper.CalculateEffectAndMeasureByType(this);
        }

        /// <summary>
        /// 计算AQI相关（需要已经先计算好空气质量指数类别）
        /// </summary>
        public override void CalculateAQIAbout()
        {
            AQIHelper.CalculateAQIAboutByType(this);
        }

        /// <summary>
        /// 计算超标污染物
        /// </summary>
        public virtual void CalculateNonAttainmentPollutant()
        {
            AQIHelper.CalculateNonAttainmentPollutant(this);
        }

        /// <summary>
        /// 计算空气质量指数详细结果
        /// </summary>
        public virtual void CalculateAQIResult()
        {
            AQIHelper.CalculateDayAQI(this);
        }
    }
}
