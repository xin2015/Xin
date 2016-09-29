using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Xin.FastReflection
{
    public class FieldAccessorFactory : IFastReflectionFactory<FieldInfo, FieldAccessor>
    {
        public FieldAccessor Create(FieldInfo key)
        {
            return new FieldAccessor(key);
        }
    }
}
