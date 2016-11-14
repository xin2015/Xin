using Common.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xin.Extensions;
using Xin.WindowsFormsApplication.Entities;
using Xin.WindowsFormsApplication.MeteorologyDataService;

namespace Xin.WindowsFormsApplication
{
    public partial class SyncForm : Form
    {
        private ILog logger;
        private DateTime beginTime;
        private DateTime endTime;
        private SqlHelper source;
        private SqlHelper target;
        private string NMCCityCode = ConfigurationManager.AppSettings["NMCCityCode"];
        private string CityCode = ConfigurationManager.AppSettings["CityCode"];

        public SyncForm()
        {
            InitializeComponent();
            logger = LogManager.GetLogger<SyncForm>();
            source = new SqlHelper(ConfigurationManager.ConnectionStrings["SourceConnection"].ConnectionString);
            target = new SqlHelper(ConfigurationManager.ConnectionStrings["TargetConnection"].ConnectionString);
        }

        private bool GetDateTime()
        {
            bool result;
            try
            {
                beginTime = Convert.ToDateTime(textBox1.Text.Trim());
                if (string.IsNullOrWhiteSpace(textBox2.Text.Trim()))
                {
                    endTime = beginTime;
                }
                else
                {
                    endTime = Convert.ToDateTime(textBox2.Text.Trim());
                }
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
                        List<Weather_D_SpiDatum> data = client.GetDaySpiData(new string[] { NMCCityCode }, beginTime, endTime).ToList();
                        List<NMCMeteorologyMonitorData> list = new List<NMCMeteorologyMonitorData>();
                        data.ForEach(o =>
                        {
                            NMCMeteorologyMonitorData item = new NMCMeteorologyMonitorData();
                            item.CityCode = CityCode;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                if (GetDateTime())
                {
                    List<Station> sourceStations = StationRepository.GetAllList(source);
                    List<Station> targetStations = StationRepository.GetAllList(target);
                    string[] tables = new string[] { "Src", "App" };
                    foreach (Station targetStation in targetStations)
                    {
                        Station sourceStation = sourceStations.FirstOrDefault(o => o.UniqueCode == targetStation.UniqueCode);
                        if (sourceStation != null)
                        {
                            foreach (string table in tables)
                            {
                                string cmdText = string.Format("select * from Air_h_{0}_{1}_{2} where TimePoint between @BeginTime and @EndTime", beginTime.Year, sourceStation.Code, table);
                                SqlParameter[] parameters = new SqlParameter[]{
                                    new SqlParameter("@BeginTime",beginTime),
                                    new SqlParameter("@EndTime",endTime)
                                };
                                DataTable dt = source.ExecuteDataTable(cmdText, parameters);
                                dt.TableName = string.Format("Air_h_{0}_{1}_{2}", beginTime.Year, targetStation.Code, table);
                                try
                                {
                                    target.Insert(dt);
                                }
                                catch (SqlException)
                                {
                                    cmdText = string.Format("delete {0} where TimePoint between @BeginTime and @EndTime", dt.TableName);
                                    parameters = new SqlParameter[]{
                                        new SqlParameter("@BeginTime",beginTime),
                                        new SqlParameter("@EndTime",endTime)
                                    };
                                    target.ExecuteNonQuery(cmdText, parameters);
                                    target.Insert(dt);
                                }
                            }
                        }
                    }
                    result = string.Format("同步国控点小时监测数据成功！{0}", DateTime.Now);
                }
                else
                {
                    result = "请输入正确的时间";
                }
            }
            catch (Exception ex)
            {
                result = string.Format("同步国控点小时监测数据失败！{0}", DateTime.Now);
                logger.Fatal("同步国控点小时监测数据失败！", ex);
            }
            textBox3.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                if (GetDateTime())
                {
                    List<Station> sourceStations = StationRepository.GetAllList(source);
                    List<Station> targetStations = StationRepository.GetAllList(target);
                    string[] tables = new string[] { "Src", "App" };
                    foreach (Station targetStation in targetStations)
                    {
                        Station sourceStation = sourceStations.FirstOrDefault(o => o.UniqueCode == targetStation.UniqueCode);
                        if (sourceStation != null)
                        {
                            foreach (string table in tables)
                            {
                                string cmdText = string.Format("select * from Air_day_AQI_{0} where StationCode = @StationCode and Date between @BeginTime and @EndTime", table);
                                SqlParameter[] parameters = new SqlParameter[]{
                                    new SqlParameter("@StationCode",sourceStation.Code),
                                    new SqlParameter("@BeginTime",beginTime),
                                    new SqlParameter("@EndTime",endTime)
                                };
                                DataTable dt = source.ExecuteDataTable(cmdText, parameters);
                                dt.TableName = string.Format("Air_day_AQI_{0}", table);
                                try
                                {
                                    target.Insert(dt);
                                }
                                catch (SqlException)
                                {
                                    cmdText = string.Format("delete {0} where StationCode = @StationCode and Date between @BeginTime and @EndTime", dt.TableName);
                                    parameters = new SqlParameter[]{
                                        new SqlParameter("@StationCode",targetStation.Code),
                                        new SqlParameter("@BeginTime",beginTime),
                                        new SqlParameter("@EndTime",endTime)
                                    };
                                    target.ExecuteNonQuery(cmdText, parameters);
                                    target.Insert(dt);
                                }
                            }
                        }
                    }
                    result = string.Format("同步国控点日均空气质量数据成功！{0}", DateTime.Now);
                }
                else
                {
                    result = "请输入正确的时间";
                }
            }
            catch (Exception ex)
            {
                result = string.Format("同步国控点日均空气质量数据失败！{0}", DateTime.Now);
                logger.Fatal("同步国控点日均空气质量数据失败！", ex);
            }
            textBox3.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                if (GetDateTime())
                {
                    List<Station> sourceStations = StationRepository.GetAllList(source);
                    List<Station> targetStations = StationRepository.GetAllList(target);
                    string[] tables = new string[] { "Src", "App" };
                    foreach (Station targetStation in targetStations)
                    {
                        Station sourceStation = sourceStations.FirstOrDefault(o => o.UniqueCode == targetStation.UniqueCode);
                        if (sourceStation != null)
                        {
                            foreach (string table in tables)
                            {
                                string cmdText = string.Format("select * from MP_day_Avg_{0} where StationCode = @StationCode and Date between @BeginTime and @EndTime", table);
                                SqlParameter[] parameters = new SqlParameter[]{
                                    new SqlParameter("@StationCode",sourceStation.Code),
                                    new SqlParameter("@BeginTime",beginTime),
                                    new SqlParameter("@EndTime",endTime)
                                };
                                DataTable dt = source.ExecuteDataTable(cmdText, parameters);
                                dt.TableName = string.Format("MP_day_Avg_{0}", table);
                                try
                                {
                                    target.Insert(dt);
                                }
                                catch (SqlException)
                                {
                                    cmdText = string.Format("delete {0} where StationCode = @StationCode and Date between @BeginTime and @EndTime", dt.TableName);
                                    parameters = new SqlParameter[]{
                                        new SqlParameter("@StationCode",targetStation.Code),
                                        new SqlParameter("@BeginTime",beginTime),
                                        new SqlParameter("@EndTime",endTime)
                                    };
                                    target.ExecuteNonQuery(cmdText, parameters);
                                    target.Insert(dt);
                                }
                            }
                        }
                    }
                    result = string.Format("同步国控点日均气象数据成功！{0}", DateTime.Now);
                }
                else
                {
                    result = "请输入正确的时间";
                }
            }
            catch (Exception ex)
            {
                result = string.Format("同步国控点日均气象数据失败！{0}", DateTime.Now);
                logger.Fatal("同步国控点日均气象数据失败！", ex);
            }
            textBox3.Text = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                if (GetDateTime())
                {
                    List<Station> sourceStations = StationRepository.GetAllList(source);
                    List<Station> targetStations = StationRepository.GetAllList(target);
                    foreach (Station targetStation in targetStations)
                    {
                        Station sourceStation = sourceStations.FirstOrDefault(o => o.UniqueCode == targetStation.UniqueCode);
                        if (sourceStation != null)
                        {
                            string cmdText = string.Format("select * from Moniter_h_{0}_{1} where TimePoint between @BeginTime and @EndTime", beginTime.Year, sourceStation.Code);
                            SqlParameter[] parameters = new SqlParameter[]{
                                    new SqlParameter("@BeginTime",beginTime),
                                    new SqlParameter("@EndTime",endTime)
                                };
                            DataTable dt = source.ExecuteDataTable(cmdText, parameters);
                            dt.TableName = string.Format("Moniter_h_{0}_{1}", beginTime.Year, targetStation.Code);
                            try
                            {
                                target.Insert(dt);
                            }
                            catch (SqlException)
                            {
                                cmdText = string.Format("delete {0} where TimePoint between @BeginTime and @EndTime", dt.TableName);
                                parameters = new SqlParameter[]{
                                        new SqlParameter("@BeginTime",beginTime),
                                        new SqlParameter("@EndTime",endTime)
                                    };
                                target.ExecuteNonQuery(cmdText, parameters);
                                target.Insert(dt);
                            }
                        }
                    }
                    result = string.Format("同步国控点小时质控数据成功！{0}", DateTime.Now);
                }
                else
                {
                    result = "请输入正确的时间";
                }
            }
            catch (Exception ex)
            {
                result = string.Format("同步国控点小时质控数据失败！{0}", DateTime.Now);
                logger.Fatal("同步国控点小时质控数据失败！", ex);
            }
            textBox3.Text = result;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                if (GetDateTime())
                {
                    using (MeteorologyDataClient client = new MeteorologyDataClient())
                    {
                        List<City_WeatherForecastInfo> list = client.GetDayForecastData(new string[] { NMCCityCode }, beginTime, endTime).ToList();
                        list.ForEach(o => o.CityCode = CityCode);
                        SqlHelper.Default.Insert(list.GetDataTable("City_WeatherForecastInfo", "ExtensionData"));
                        result = string.Format("同步城市气象7天预报数据成功！{0}", DateTime.Now);
                    }
                }
                else
                {
                    result = "请输入正确的时间";
                }
            }
            catch (Exception ex)
            {
                result = string.Format("同步城市气象7天预报数据失败！{0}", DateTime.Now);
                logger.Error("同步城市气象7天预报数据失败！", ex);
            }
            textBox3.Text = result;
        }
    }
}
