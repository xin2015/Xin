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
using Xin.WindowsFormsApplication.MeteorologyDataService;

namespace Xin.WindowsFormsApplication
{
    public partial class SyncForm : Form
    {
        private ILog logger;
        private DateTime beginTime;
        private DateTime endTime;

        public SyncForm()
        {
            InitializeComponent();
            logger = LogManager.GetLogger<SyncForm>();
        }

        private bool GetDateTime()
        {
            bool result;
            try
            {
                beginTime = Convert.ToDateTime(textBox1.Text.Trim());
                endTime = Convert.ToDateTime(textBox2.Text.Trim());
                result = true;
            }
            catch (Exception e)
            {
                logger.Error("GetDateTime failed.", e);
                result = false;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                if (GetDateTime())
                {
                    using (MeteorologyDataClient client = new MeteorologyDataClient())
                    {
                        List<Weather_D_SpiDatum> data = client.GetDaySpiData(new string[] { "101280409" }, beginTime, endTime).ToList();
                        List<NMCMeteorologyMonitorData> list = new List<NMCMeteorologyMonitorData>();
                        data.ForEach(o =>
                        {
                            NMCMeteorologyMonitorData item = new NMCMeteorologyMonitorData();
                            item.CityCode = "441400";
                            item.TimePoint = o.TimePoint.Value;
                            item.CreateTime = DateTime.Now;
                            item.WindDirection = o.WindDirection;
                            item.WindSpeed = o.WindSpeed;
                            item.Pressure = o.AirPress;
                            item.AirTemperature = o.AirTemperature;
                            item.Humidity = o.RelHumidity;
                            item.Rainfall = o.RainFall;
                            item.Apparent = o.Apparent;
                            list.Add(item);
                        });
                        SqlHelper.Default.Insert(list.GetDataTable("City_Monitor_Day_Weather"));
                        result = string.Format("同步气象监测日均数据成功！{0}", DateTime.Now);
                    }
                }
                else
                {
                    result = "请输入正确的时间";
                }
            }
            catch (Exception ex)
            {
                result = string.Format("同步气象监测日均数据失败！{0}", DateTime.Now);
                logger.Error("同步气象监测日均数据失败！", ex);
            }
            textBox3.Text = result;
        }
    }
}
