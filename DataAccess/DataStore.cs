using Models;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public static class DataStore
    {
        public static List<User> UserTbl { get; set; } = new List<User>();
        public static List<Address> AddressTbl { get; set; } = new List<Address>();
    }
}
