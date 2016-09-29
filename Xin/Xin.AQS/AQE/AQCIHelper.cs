using Xin.FastReflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Xin.AQS.AQE
{
    /// <summary>
    /// 综合质量指数计算工具类
    /// </summary>
    public class AQCIHelper
    {
        /// <summary>
        /// IAirData属性
        /// </summary>
        private static PropertyAccessor[] IAirDataProperties;
        /// <summary>
        /// IAQCIReport单项质量指数属性
        /// </summary>
        private static Dictionary<string, PropertyAccessor> IAQCIPropertiesDic;
        /// <summary>
        /// 污染物监测项浓度二级标准字典
        /// </summary>
        private static Dictionary<string, int> limitDic;

        /// <summary>
        /// 静态构造函数
        /// </summary>
        static AQCIHelper()
        {
            IAirDataProperties = typeof(IAirData).GetProperties().Select(o => PropertyAccessor.Get(o)).ToArray();
            limitDic = new Dictionary<string, int>(){
                {"SO2",60},
                {"NO2",40},
                {"PM10",70},
                {"CO",4},
                {"O3",160},
                {"PM25",35}
            };
            PropertyInfo[] IAQCIReportProperties = typeof(IAQCIReport).GetProperties();
            IAQCIPropertiesDic = new Dictionary<string, PropertyAccessor>();
            foreach (string pollutant in limitDic.Keys)
            {
                IAQCIPropertiesDic.Add(pollutant, PropertyAccessor.Get(IAQCIReportProperties.First(o => o.Name == string.Format("I{0}", pollutant))));
            }
        }

        #region 私有方法
        /// <summary>
        /// 计算单项质量指数
        /// </summary>
        /// <param name="data">综合质量指数计算接口</param>
        /// <returns></returns>
        private static Dictionary<string, decimal> GetIAQCIDic(IAQCICalculate data)
        {
            Dictionary<string, decimal> IAQCIDic = new Dictionary<string, decimal>();
            foreach (PropertyAccessor property in IAirDataProperties)
            {
                object value = property.GetValue(data);
                if (value != null)
                {
                    decimal decimalValue = Convert.ToDecimal(value);
                    if (decimalValue >= 0) IAQCIDic.Add(property.PropertyInfo.Name, Math.Round(decimalValue / limitDic[property.PropertyInfo.Name], 2));
                }
            }
            return IAQCIDic;
        }

        /// <summary>
        /// 计算综合质量指数、最大质量指数、首要污染物
        /// </summary>
        /// <param name="data">综合质量指数计算接口</param>
        /// <param name="IAQCIDic">单项质量指数字典</param>
        private static void CalculateAQCI(IAQCICalculate data, Dictionary<string, decimal> IAQCIDic)
        {
            if (IAQCIDic.Count == 6)
            {
                data.AQCI = IAQCIDic.Sum(o => o.Value);
                data.AQMI = IAQCIDic.Max(o => o.Value);
                data.PrimaryPollutant = string.Join(",", IAQCIDic.Where(t => t.Value == data.AQMI).Select(t => t.Key));
            }
        }

        /// <summary>
        /// 赋值单项质量指数分指数
        /// </summary>
        /// <param name="data">综合质量指数报表接口</param>
        /// <param name="IAQCIDic">单项质量指数字典</param>
        private static void CalculateIAQCI(IAQCIReport data, Dictionary<string, decimal> IAQCIDic)
        {
            foreach (var item in IAQCIDic)
            {
                IAQCIPropertiesDic[item.Key].SetValue(data, item.Value);
            }
        }
        #endregion
        #region 公共方法
        /// <summary>
        /// 计算百分位数
        /// </summary>
        /// <param name="values">按从小到大排序的数据，且数组长度需大于1</param>
        /// <param name="p">百分位</param>
        /// <returns>百分位数</returns>
        public static decimal CalculatePercentile(decimal[] values, decimal p)
        {
            decimal k = (values.Length - 1) * p;
            int s = (int)Math.Floor(k);
            decimal percentile = values[s] + (k - s) * (values[s + 1] - values[s]);
            return percentile;
        }

        /// <summary>
        /// 计算综合质量指数
        /// </summary>
        /// <param name="data">综合质量指数计算接口</param>
        public static void CalculateAQCI(IAQCICalculate data)
        {
            Dictionary<string, decimal> IAQCIDic = GetIAQCIDic(data);
            CalculateAQCI(data, IAQCIDic);
        }

        /// <summary>
        /// 计算综合质量指数
        /// </summary>
        /// <param name="data">综合质量指数报表</param>
        public static void CalculateAQCI(IAQCIReport data)
        {
            Dictionary<string, decimal> IAQCIDic = GetIAQCIDic(data);
            CalculateIAQCI(data, IAQCIDic);
            CalculateAQCI(data, IAQCIDic);
        }

        /// <summary>
        /// 计算单项质量指数
        /// </summary>
        /// <param name="data">综合质量指数报表接口</param>
        public static void CalculateIAQCI(IAQCIReport data)
        {
            Dictionary<string, decimal> IAQCIDic = GetIAQCIDic(data);
            CalculateIAQCI(data, IAQCIDic);
        }
        #endregion
    }
}
