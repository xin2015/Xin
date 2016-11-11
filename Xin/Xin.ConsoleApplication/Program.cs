using DotNet4.Utilities;
using Ivony.Html;
using Ivony.Html.Parser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
            Person a = new Person("liuhx", 25, "man");
            Person b = new Person("liusp", 49, "man");
            Person c = new Person("pangcf", 49, "woman");

            int length = 1000000;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            PropertyInfo property = a.GetType().GetProperty("DefaultName");
            try
            {
                ParameterExpression instanceParam = Expression.Parameter(typeof(object));
                MethodCallExpression call;
                if (property.GetMethod.IsStatic)
                {
                    UnaryExpression instanceConvert = Expression.Convert(instanceParam, property.ReflectedType);
                    call = Expression.Call(instanceConvert, property.GetMethod);
                    var lambda = Expression.Lambda<Func<object, object>>(call, instanceParam);
                    var func = lambda.Compile();
                    string re = (string)func(a);
                }
                else
                {
                    UnaryExpression instanceConvert = Expression.Convert(instanceParam, property.ReflectedType);
                    call = Expression.Call(instanceConvert, property.GetMethod);
                    var lambda = Expression.Lambda<Func<object, object>>(call, instanceParam);
                    var func = lambda.Compile();
                    string re = (string)func(a);
                }
            }
            catch (Exception e)
            {
                string me = e.Message;
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadLine();






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
            var param_value = Expression.Parameter(typeof(object), "value");
            var body_value = Expression.Convert(param_value, property.PropertyType);
            var body = Expression.Call(param_instance, method, body_value);
            Expression.Lambda<Action<T, object>>(body, param_instance, param_value).Compile()(instance, value);
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

    public class Person
    {
        public static string DefaultName { get; }

        static Person()
        {
            DefaultName = "Default";
        }

        public string Name { get; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public List<Person> Family { get; set; }

        public Person()
        {
            Family = new List<Person>();
        }

        public Person(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Family = new List<Person>();
        }

        public string Introduction()
        {
            return string.Format("Hello, my name is {0}, I'm {1} years old.", Name, Age);
        }

        public void AddFamily(Person p)
        {
            Family.Add(p);
        }
    }
}
