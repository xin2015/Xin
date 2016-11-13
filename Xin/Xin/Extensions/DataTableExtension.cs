using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Widgets.FastReflection;

namespace Xin.Extensions
{
    /// <summary>
    /// DataTable扩展类
    /// </summary>
    public static class DataTableExtension
    {
        /// <summary>
        /// 将DataTable转换为实体类集合（不做类型转换）
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="dt">DataTable</param>
        /// <returns></returns>
        public static List<T> GetList<T>(this DataTable dt) where T : class, new()
        {
            PropertyAccessorFactory factory = new PropertyAccessorFactory();
            IPropertyAccessor[] accessors = typeof(T).GetProperties().Select(o => factory.Get(o)).ToArray();
            List<T> list = new List<T>();
            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                foreach (IPropertyAccessor accessor in accessors)
                {
                    var value = dr[accessor.Property.Name];
                    if (!Convert.IsDBNull(value))
                    {
                        accessor.SetValue(t, value);
                    }
                }
                list.Add(t);
            }
            return list;
        }

        /// <summary>
        /// 将DataTable转换为实体类集合（可做类型转换）
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="dt">DataTable</param>
        /// <param name="tryConvert">是否在必要时做可行的类型转换</param>
        /// <returns></returns>
        public static List<T> GetList<T>(this DataTable dt, bool tryConvert) where T : class, new()
        {
            List<T> list;
            if (tryConvert)
            {
                list = new List<T>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    list.Add(new T());
                }
                PropertyAccessorFactory factory = new PropertyAccessorFactory();
                IPropertyAccessor[] accessors = typeof(T).GetProperties().Select(o => factory.Get(o)).ToArray();
                foreach (IPropertyAccessor accessor in accessors)
                {
                    int i = 0;
                    Type propertyType = accessor.Property.PropertyType;
                    DataColumn dc = dt.Columns[dt.Columns.IndexOf(accessor.Property.Name)];
                    if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                    {
                        propertyType = Nullable.GetUnderlyingType(propertyType);
                    }
                    if (dc.DataType.Equals(propertyType))
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            var value = dr[dc.ColumnName];
                            if (!Convert.IsDBNull(value))
                            {
                                accessor.SetValue(list[i], value);
                            }
                            i++;
                        }
                    }
                    else
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            var value = dr[accessor.Property.Name];
                            if (!Convert.IsDBNull(value))
                            {
                                accessor.SetValue(list[i], Convert.ChangeType(value, propertyType));
                            }
                            i++;
                        }
                    }
                }
            }
            else
            {
                list = dt.GetList<T>();
            }
            return list;
        }
    }
}
