using System.IO;
using System.Xml;
using Model;

namespace Serializer
{
    public class XmlUserSerializer : IUserSerializer
    {
        public string Serialize(User user)
        {
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(user.GetType());
            using var stringWriter = new StringWriter();
            var settings = new XmlWriterSettings {Indent = true, IndentChars = "  "};
            using var xmlWriter = XmlWriter.Create(stringWriter, settings);
            xmlSerializer.Serialize(xmlWriter, user);
            return stringWriter.ToString();
        }
    }
}