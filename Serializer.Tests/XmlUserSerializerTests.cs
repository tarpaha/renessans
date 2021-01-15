using Model;
using NUnit.Framework;

namespace Serializer.Tests
{
    public class XmlUserSerializerTests
    {
        [Test]
        public void Serialize_User_ContainsName()
        {
            const string name = "John"; 
            var user = new User { Passports = new [] { new Passport { FName = name } } };
            var str = new XmlUserSerializer().Serialize(user);
            Assert.That(str.Contains(name));
        }
    }
}