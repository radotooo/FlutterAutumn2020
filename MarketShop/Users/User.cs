using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore.Users
{
    public class User
    {
        private string fullName;
        public User(string fullName)
        {
            this.fullName = fullName;
        }
        public string FullName => this.fullName;
    }
}
