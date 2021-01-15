using Model;

namespace Serializer
{
    public interface IUserSerializer
    {
        string Serialize(User user);
    }
}