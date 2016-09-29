using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Xin.TopshelfQuartz
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<SyncService>();
                x.RunAsLocalSystem();
                x.SetDescription(Configuration.Description);
                x.SetDisplayName(Configuration.DisplayName);
                x.SetServiceName(Configuration.ServiceName);
                x.StartAutomatically();
            });
        }
    }
}
