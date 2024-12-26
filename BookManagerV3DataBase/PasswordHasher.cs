using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerV3DataBase
{
    internal class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            if (password == null || hashedPassword == null)
            {
                throw new ArgumentNullException(nameof(password) + " or " + nameof(hashedPassword));
            }
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
