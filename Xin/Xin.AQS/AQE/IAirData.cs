using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xin.AQS.AQE
{
    /// <summary>
    /// 空气质量基本评价项目
    /// </summary>
    public interface IAirData
    {
        /// <summary>
        /// 二氧化硫（SO2）平均浓度（μg/m³）
        /// </summary>
        decimal? SO2 { get; set; }
        /// <summary>
        /// 二氧化氮（NO2）平均浓度（μg/m³）
        /// </summary>
        decimal? NO2 { get; set; }
        /// <summary>
        /// 颗粒物（粒径小于等于10μm）平均浓度（μg/m³）
        /// </summary>
        decimal? PM10 { get; set; }
        /// <summary>
        /// 一氧化碳（CO）平均浓度（mg/m³）
        /// </summary>
        decimal? CO { get; set; }
        /// <summary>
        /// 臭氧（O3）平均浓度（μg/m³）
        /// </summary>
        decimal? O3 { get; set; }
        /// <summary>
        /// 颗粒物（粒径小于等于2.5μm）平均浓度（μg/m³）
        /// </summary>
        decimal? PM25 { get; set; }
    }
}
