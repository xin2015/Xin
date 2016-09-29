using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Xin.FastReflection
{
    public class MethodInvokerFactory : IFastReflectionFactory<MethodInfo, MethodInvoker>
    {
        public MethodInvoker Create(MethodInfo key)
        {
            return new MethodInvoker(key);
        }
    }
}
