using System.Linq;
using Model;

namespace View
{
    public static class User
    {
        public static string GetFullName(Model.User user, Language language)
        {
            var passport = user.Passports.FirstOrDefault(p => p.Language == language);
            return passport != null
                ? $"{passport.LName} {passport.FName} {passport.MName}"
                : null;
        }
    }
}