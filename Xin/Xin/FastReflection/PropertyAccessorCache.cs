using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Xin.FastReflection
{
    public class PropertyAccessorCache : FastReflectionCache<PropertyInfo, PropertyAccessor>
    {
        protected override PropertyAccessor Create(PropertyInfo key)
        {
            return new PropertyAccessor(key);
        }
    }
}
