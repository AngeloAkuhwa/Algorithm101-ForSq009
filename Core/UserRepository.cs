using DataAccess;
using Models;
using System;
using System.Security.Cryptography;

namespace Core
{
    public class UserRepository
    {
       
        public User GetUserByEmail(string email)
        {
            User userToReturn = null;
            // get user by email
            foreach (var user in DataStore.UserTbl)
            {
                if (user.Email == email)
                {
                    userToReturn = new User
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        DateCreated = user.DateCreated
                    };
                    return userToReturn;
                }
            }

            return null;
        }
    }
}
