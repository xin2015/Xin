using DotNet4.Utilities;
using Ivony.Html;
using Ivony.Html.Parser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xin.Extensions;

namespace Xin.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Test a = new Test();
            Type t = a.GetType();
            t.GetProperty("Code").FastSetValue<Test>(a, "1001A");
            t.GetProperty("Name").FastSetValueN(a, "监测中心站");
            A b = new A();
            b.Name = "AQI";
            b.Value = 35;
            t.GetProperty("Value").FastSetValueN(a, b);
            object code = t.GetProperty("Code").FastGetValue<Test>(a);
            object name = t.GetProperty("Name").FastGetValueN(a);
            a = null;
            //string url = "http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/201608/t20160809_1386477.html";
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Code", typeof(int));
            //dt.Columns.Add("Name", typeof(string));
            //dt.TableName = "Division";
            //JumonyParser jp = new JumonyParser();
            //IHtmlDocument html = jp.LoadDocument(url, Encoding.UTF8);
            //List<IHtmlElement> list = html.Find(".MsoNormal").ToList();
            //foreach (IHtmlElement item in list)
            //{
            //    DataRow dr = dt.NewRow();
            //    dr["Code"] = int.Parse(item.Elements().First().InnerText().Trim());
            //    dr["Name"] = item.Elements().Last().InnerText().Trim();
            //    dt.Rows.Add(dr);
            //}
            //SqlHelper.Default.Insert(dt);
        }
    }

    public static class Temp
    {
        public static void FastSetValue<T>(this PropertyInfo property, T instance, object value)
        {
            MethodInfo method = property.GetSetMethod();
            var param_instance = Expression.Parameter(typeof(T), "instance");
            var param_method = Expression.Parameter(typeof(MethodInfo), "method");
            var param_value = Expression.Parameter(typeof(object), "value");
            var body_value = Expression.Convert(param_value, property.PropertyType);
            var body = Expression.Call(param_instance, method, body_value);
            Expression.Lambda<Action<T, MethodInfo, object>>(body, param_instance, param_method, param_value).Compile()(instance, method, value);
        }

        public static void FastSetValueN(this PropertyInfo property, object instance, object value)
        {
            MethodInfo method = property.GetSetMethod();
            var param_instance = Expression.Parameter(typeof(object), "instance");
            var param_method = Expression.Parameter(typeof(MethodInfo), "method");
            var param_value = Expression.Parameter(typeof(object), "value");
            var body_value = Expression.Convert(param_value, property.PropertyType);
            var body_instance = Expression.Convert(param_instance, property.DeclaringType);
            var body = Expression.Call(body_instance, method, body_value);
            Expression.Lambda<Action<object, MethodInfo, object>>(body, param_instance, param_method, param_value).Compile()(instance, method, value);
        }

        public static object FastGetValue<T>(this PropertyInfo property, T instance)
        {
            MethodInfo method = property.GetGetMethod();
            var param_instance = Expression.Parameter(typeof(T), "instance");
            var param_method = Expression.Parameter(typeof(MethodInfo), "method");
            var body = Expression.Call(param_instance, method);
            return Expression.Lambda<Func<T, MethodInfo, object>>(body, param_instance, param_method).Compile()(instance, method);
        }

        public static object FastGetValueN(this PropertyInfo property, object instance)
        {
            MethodInfo method = property.GetGetMethod();
            var param_instance = Expression.Parameter(typeof(object), "instance");
            var param_method = Expression.Parameter(typeof(MethodInfo), "method");
            var body_instance = Expression.Convert(param_instance, property.DeclaringType);
            var body = Expression.Call(body_instance, method);
            return Expression.Lambda<Func<object, MethodInfo, object>>(body, param_instance, param_method).Compile()(instance, method);
        }

    }

    public class Test
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public A Value { get; set; }
    }

    public class A
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
