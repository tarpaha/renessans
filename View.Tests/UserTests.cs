using Model;
using NUnit.Framework;

namespace View.Tests
{
    public class UserTests
    {
        [Test]
        public void GetFullName_Works_Correctly()
        {
            var user = new Model.User { Passports = new []
            {
                new Passport { Language  = Language.Rus, FName = "Иван", LName = "Петров"},
                new Passport { Language  = Language.Eng, FName = "John", LName = "Doe"}
            }};

            Assert.That(User.GetFullName(user, Language.Rus).Trim(), Is.EqualTo("Петров Иван"));
            Assert.That(User.GetFullName(user, Language.Eng).Trim(), Is.EqualTo("Doe John"));
        }
    }
}