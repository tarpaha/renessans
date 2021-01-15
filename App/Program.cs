using System;
using Model;
using Serializer;
using Writers;

namespace App
{
    public static class Program
    {
        public static void Main()
        {
            var user = new User {Passports = new[] {new Passport {Language = Language.Eng, FName = "John", LName = "Doe"}}};
            var serializer = new XmlUserSerializer();
            var writer = new DatabaseWriter();

            Console.WriteLine($"Name: {View.User.GetFullName(user, Language.Eng)}");
            writer.Write(serializer.Serialize(user));
        }
    }
}