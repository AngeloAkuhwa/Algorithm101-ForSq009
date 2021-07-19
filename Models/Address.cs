using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Address
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string StreetName { get; set; }
        public string Town { get; set; }
        public string State { get; set; }
        public string country { get; set; }
        private int count = 1;
        public Address()
        {
            Id += count++;
        }
    }
}
