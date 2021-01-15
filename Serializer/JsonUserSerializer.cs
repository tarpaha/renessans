using System;
using Model;

namespace Serializer
{
    public class JsonUserSerializer : IUserSerializer
    {
        public string Serialize(User user)
        {
            throw new NotSupportedException();
        }
    }
}