using Common.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Xin.TopshelfQuartz
{
    class FastRecoverDDJob : IJob
    {
        private static ILog logger;
        public static string CronExpression { get; set; }
        public static string TableName { get; set; }

        static FastRecoverDDJob()
        {
            logger = LogManager.GetLogger<FastRecoverDDJob>();
            CronExpression = Configuration.FastRecoverDDJobCronExpression;
        }

        public void Execute(IJobExecutionContext context)
        {
            try
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                Type[] types = asm.GetTypes();
                List<Type> typeList = new List<Type>();
                foreach (Type t in types)
                {
                    if (t.GetInterfaces().Contains(typeof(IJob)) && t.GetProperty("FastRecoverJob") != null && t.GetProperty("FastRecoverJob").GetValue(null).ToString() == "FastRecoverDDJob")
                    {
                        typeList.Add(t);
                    }
                }
                List<MissingData> missingDataList = MissingDataHelper.GetList();
                missingDataList.ForEach(o =>
                {
                    Type type = typeList.FirstOrDefault(p => p.GetProperty("TableName").GetValue(null).ToString() == o.Code);
                    if (type != null)
                    {
                        type.GetMethod("FastRecover").Invoke(null, new object[] { o });
                    }
                });
            }
            catch (Exception e)
            {
                logger.Error("FastRecoverDDJob Execute failed.", e);
            }
        }
    }
}
