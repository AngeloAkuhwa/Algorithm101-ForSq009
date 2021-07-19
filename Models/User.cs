using System;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordKey { get; set; }
        public byte[] PasswordHash { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public Address Address { get; set; } = null;
        private int count = 1;
        public User()
        {
            Id += count++;
        }
    }
}
