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
using Xin.Expressions;
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
            try
            {
                MethodInfo method = a.GetType().GetMethods().Last(o => o.Name.Contains("AddFamily"));
                VoidMethodInvoker invoker = new VoidMethodInvoker(method);
                invoker.Invoke(a, "unknown", 25, "women");

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
        public List<Person> Family { get; }

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

        public void AddFamily(string name, int age, string sex)
        {
            Person p = new Person(name, age, sex);
            p.AddFamily(this);
            Family.Add(p);
        }
    }
}
