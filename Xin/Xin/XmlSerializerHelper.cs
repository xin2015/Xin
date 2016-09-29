using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Xin
{
    /// <summary>
    /// XML序列化反序列化工具类
    /// </summary>
    public class XmlSerializerHelper
    {
        /// <summary>  
        /// 反序列化XML为类实例  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="xmlObj"></param>  
        /// <returns></returns>  
        public static T DeserializeXML<T>(string xmlObj) where T : class, new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T result;
            using (StringReader sr = new StringReader(xmlObj))
            {
                result = (T)serializer.Deserialize(sr);
            }
            return result;
        }

        /// <summary>  
        /// 序列化类实例为XML  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="obj"></param>  
        /// <returns></returns>  
        public static string SerializeXML<T>(T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            string result;
            using (StringWriter sw = new StringWriter())
            {
                serializer.Serialize(sw, obj);
                result = sw.ToString();
            }
            return result;
        }
    }
}
