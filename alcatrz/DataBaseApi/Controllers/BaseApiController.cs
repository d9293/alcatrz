using System;
using System.IO;
using System.Web.Http;
using System.Xml.Serialization;
namespace DataBaseApi.Controllers
{
    public class BaseApiController : ApiController
    {
        #region сериализация данных
        public string Serialize(Type tp, object obj)
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            XmlSerializer serializer = new XmlSerializer(tp);
            StringWriter sw = new StringWriter(result);
            serializer.Serialize(sw, obj);
            sw.Close();
            return result.ToString();
        }
        #endregion

        #region десериализация Mock данных
        public object DeserializeMock(Type type, string xml)
        {
            XmlSerializer serializer = new XmlSerializer(type);
            // Путь проекта
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            StreamReader reader = new StreamReader(@"" + path + "\\Mock\\" + xml + ".xml");
            object _object = serializer.Deserialize(reader.BaseStream);
            reader.Close();
            return _object;
        }
        #endregion
    }
}
