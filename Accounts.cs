using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_Hungary_for_hungry
{
    internal class Accounts
    {
        public enum UserType
        {
            Admin,
            Restaurant,
            Customer,
            None
        }

        public string id;
        public string username;
        public string password;
        public UserType type = UserType.None;
    }
}
