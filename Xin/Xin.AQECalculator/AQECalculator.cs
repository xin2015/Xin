using Common.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xin.AQS.AQE;

namespace Xin.AQECalculator
{
    public partial class AQECalculator : Form
    {
        private ILog logger;
        public AQECalculator()
        {
            InitializeComponent();
            logger = LogManager.GetLogger<AQECalculator>();
        }

        private void InitAirData(IAirData data)
        {
            decimal value;
            if (!string.IsNullOrWhiteSpace(SO2.Text.Trim()) && decimal.TryParse(SO2.Text, out value)) data.SO2 = value;
            if (!string.IsNullOrWhiteSpace(NO2.Text.Trim()) && decimal.TryParse(NO2.Text, out value)) data.NO2 = value;
            if (!string.IsNullOrWhiteSpace(PM10.Text.Trim()) && decimal.TryParse(PM10.Text, out value)) data.PM10 = value;
            if (!string.IsNullOrWhiteSpace(CO.Text.Trim()) && decimal.TryParse(CO.Text, out value)) data.CO = value;
            if (!string.IsNullOrWhiteSpace(O3.Text.Trim()) && decimal.TryParse(O3.Text, out value)) data.O3 = value;
            if (!string.IsNullOrWhiteSpace(PM25.Text.Trim()) && decimal.TryParse(PM25.Text, out value)) data.PM25 = value;
        }

        private void InitAirDataIndex(IAQIReport data)
        {
            ISO2.Text = data.ISO2.ToString();
            INO2.Text = data.INO2.ToString();
            IPM10.Text = data.IPM10.ToString();
            ICO.Text = data.ICO.ToString();
            IO3.Text = data.IO3.ToString();
            IPM25.Text = data.IPM25.ToString();
        }

        private void InitAirDataIndex(IAQCIReport data)
        {
            ISO2.Text = data.ISO2.ToString();
            INO2.Text = data.INO2.ToString();
            IPM10.Text = data.IPM10.ToString();
            ICO.Text = data.ICO.ToString();
            IO3.Text = data.IO3.ToString();
            IPM25.Text = data.IPM25.ToString();
        }

        private void InitAQILabel()
        {
            label7.Text = "空气质量指数：";
            label9.Text = "类别：";
        }

        private void InitAQCILabel()
        {
            label7.Text = "综合质量指数：";
            label9.Text = "最大质量指数：";
        }

        private void HourAQI_Click(object sender, EventArgs e)
        {
            try
            {
                HourAQIReport har = new HourAQIReport();
                InitAirData(har);
                har.CalculateAQIReport();
                InitAirDataIndex(har);
                InitAQILabel();
                if (har.AQI.HasValue)
                {
                    AQI.Text = har.AQI.ToString();
                    PrimaryPollutant.Text = har.PrimaryPollutant;
                    AQIType.Text = har.Type;
                }
                else
                {
                    AQI.Text = string.Empty;
                    PrimaryPollutant.Text = string.Empty;
                    AQIType.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                logger.Error("计算小时AQI失败！", ex);
            }
        }

        private void DayAQI_Click(object sender, EventArgs e)
        {
            try
            {
                DayAQIReport dar = new DayAQIReport();
                InitAirData(dar);
                dar.CalculateAQIReport();
                InitAirDataIndex(dar);
                InitAQILabel();
                if (dar.AQI.HasValue)
                {
                    AQI.Text = dar.AQI.ToString();
                    PrimaryPollutant.Text = dar.PrimaryPollutant;
                    AQIType.Text = dar.Type;
                }
                else
                {
                    AQI.Text = string.Empty;
                    PrimaryPollutant.Text = string.Empty;
                    AQIType.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                logger.Error("计算日均AQI失败！", ex);
            }
        }

        private void AQCI_Click(object sender, EventArgs e)
        {
            try
            {
                AQCIReport report = new AQCIReport();
                InitAirData(report);
                report.CalculateAQCIReport();
                InitAirDataIndex(report);
                InitAQCILabel();
                if (report.AQCI.HasValue)
                {
                    AQI.Text = report.AQCI.ToString();
                    PrimaryPollutant.Text = report.PrimaryPollutant;
                    AQIType.Text = report.AQMI.ToString();
                }
                else
                {
                    AQI.Text = string.Empty;
                    PrimaryPollutant.Text = string.Empty;
                    AQIType.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                logger.Error("计算综合质量指数失败！", ex);
            }
        }

        private void ReSet_Click(object sender, EventArgs e)
        {
            SO2.Text = string.Empty;
            NO2.Text = string.Empty;
            PM10.Text = string.Empty;
            CO.Text = string.Empty;
            O3.Text = string.Empty;
            PM25.Text = string.Empty;
            ISO2.Text = string.Empty;
            INO2.Text = string.Empty;
            IPM10.Text = string.Empty;
            ICO.Text = string.Empty;
            IO3.Text = string.Empty;
            IPM25.Text = string.Empty;
            AQI.Text = string.Empty;
            PrimaryPollutant.Text = string.Empty;
            AQIType.Text = string.Empty;
        }
    }
}
