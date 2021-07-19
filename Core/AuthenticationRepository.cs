using DataAccess;
using Models;
using System.Security.Cryptography;
using System.Text;

namespace Core
{
    public class AuthenticationRepository
    {
        public string RegisterUser(User model, string passwordText)
        {
            var dbUserCount = DataStore.UserTbl.Count;

            byte[] passwordKey, passwordHash;
            if (model != null)
            {
                using (var hmac = new HMACSHA512())
                {
                    passwordKey = hmac.Key;
                    passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(passwordText));
                }

                model.PasswordHash = passwordHash;
                model.PasswordKey = passwordKey;

                DataStore.UserTbl.Add(model);

                var updatedUserCount = DataStore.UserTbl.Count;
                if (updatedUserCount > dbUserCount)
                    return "Registration successful";


            }

            return "all fields are required for registration";

        }

        public string Login(string email, string password)
        {
            byte[] passwordHash;

            foreach (var user in DataStore.UserTbl)
            {
                if(user.Email == email && password != null)
                {
                    using(var hmac = new HMACSHA512(user.PasswordKey))
                    {
                        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                    }

                    if (passwordHash == user.PasswordHash)
                        return $"Welcome {user.FirstName} {user.LastName}, your login is successful";
                }
                return "Email and Password fiels are reequired";
                
            }

            return "Email and Password fiels are reequired";
        }

    }
}
