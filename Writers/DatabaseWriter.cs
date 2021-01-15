using System;

namespace Writers
{
    public class DatabaseWriter : IWriter
    {
        public void Write(string str)
        {
            Console.WriteLine(str);
        }
    }
}