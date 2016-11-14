using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using Modules.FastReflection;

namespace Xin.Extensions
{
    /// <summary>
    /// Enumerable扩展类
    /// </summary>
    public static class EnumerableExtension
    {
        /// <summary>
        /// 将实体类集合转换为DataTable
        /// </summary>
        /// <typeparam name="T">实体类</typeparam>
        /// <param name="collection">实体类集合</param>
        /// <param name="tableName">表名</param>
        /// <param name="preclusiveColumnNames">排除的列名</param>
        /// <returns></returns>
        public static DataTable GetDataTable<T>(this IEnumerable<T> collection, string tableName, params string[] preclusiveColumnNames)
        {
            PropertyAccessorFactory factory = new PropertyAccessorFactory();
            PropertyInfo[] properties = typeof(T).GetProperties().Where(o => preclusiveColumnNames.Contains(o.Name)).ToArray();
            DataTable dt = new DataTable();
            dt.TableName = tableName;
            foreach (PropertyInfo property in properties)
            {
                Type propertyType = property.PropertyType;
                if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                {
                    dt.Columns.Add(property.Name, Nullable.GetUnderlyingType(propertyType));
                }
                else
                {
                    dt.Columns.Add(property.Name, propertyType);
                }
            }
            IPropertyAccessor[] accessors = properties.Select(o => factory.Get(o)).ToArray();
            foreach (T data in collection)
            {
                DataRow dr = dt.NewRow();
                foreach (IPropertyAccessor accessor in accessors)
                {
                    dr[accessor.Property.Name] = accessor.GetValue(data) ?? DBNull.Value;
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
