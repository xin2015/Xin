using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Xin.FastReflection
{
    public class ConstructorInvokerFactory : IFastReflectionFactory<ConstructorInfo, ConstructorInvoker>
    {
        public ConstructorInvoker Create(ConstructorInfo key)
        {
            return new ConstructorInvoker(key);
        }
    }
}
