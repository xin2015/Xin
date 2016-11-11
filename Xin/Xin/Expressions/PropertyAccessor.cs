using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Xin.Expressions
{
    /// <summary>
    /// Property（属性）快速反射接口
    /// </summary>
    public interface IPropertyAccessor
    {
        /// <summary>
        /// GetValue
        /// </summary>
        /// <param name="instance">instance</param>
        /// <returns></returns>
        object GetValue(object instance);
        /// <summary>
        /// SetValue
        /// </summary>
        /// <param name="instance">instance</param>
        /// <param name="value">value</param>
        void SetValue(object instance, object value);
        /// <summary>
        /// Property
        /// </summary>
        PropertyInfo Property { get; }
    }

    /// <summary>
    /// Property（属性）快速反射类
    /// </summary>
    public class PropertyAccessor : IPropertyAccessor
    {
        private Func<object, object> getter;
        private Action<object, object> setter;

        /// <summary>
        /// Property
        /// </summary>
        public PropertyInfo Property { get; private set; }

        /// <summary>
        /// GetValue
        /// </summary>
        /// <param name="instance">instance</param>
        /// <returns></returns>
        public object GetValue(object instance)
        {
            if (getter == null)
            {
                throw new NotSupportedException("Get method is not defined for this property.");
            }
            return getter(instance);
        }

        /// <summary>
        /// SetValue
        /// </summary>
        /// <param name="instance">instance</param>
        /// <param name="value">value</param>
        public void SetValue(object instance, object value)
        {
            if (setter == null)
            {
                throw new NotSupportedException("Set method is not defined for this property.");
            }
            setter(instance, value);
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="property">Property</param>
        public PropertyAccessor(PropertyInfo property)
        {
            Property = property;
            InitializeGet();
            InitializeSet();
        }

        private void InitializeGet()
        {
            if (Property.CanRead)
            {
                ParameterExpression instanceParam = Expression.Parameter(typeof(object));
                UnaryExpression instanceConvert = Property.GetMethod.IsStatic ? null : Expression.Convert(instanceParam, Property.ReflectedType);
                MethodCallExpression call = Expression.Call(instanceConvert, Property.GetMethod);
                getter = Expression.Lambda<Func<object, object>>(call, instanceParam).Compile();
            }
        }

        private void InitializeSet()
        {
            if (Property.CanWrite)
            {
                ParameterExpression instanceParam = Expression.Parameter(typeof(object));
                ParameterExpression valueParam = Expression.Parameter(typeof(object));
                UnaryExpression instanceConvert = Property.SetMethod.IsStatic ? null : Expression.Convert(instanceParam, Property.ReflectedType);
                UnaryExpression valueConvert = Expression.Convert(valueParam, Property.PropertyType);
                MethodCallExpression call = Expression.Call(instanceConvert, Property.SetMethod, valueConvert);
                setter = Expression.Lambda<Action<object, object>>(call, instanceParam, valueParam).Compile();
            }
        }
    }
}
