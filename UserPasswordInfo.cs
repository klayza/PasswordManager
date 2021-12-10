using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    class UserPasswordInfo
    {
        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DateCreated { get; set; }
        public string DateLastViewed { get; set; }
        public string Note { get; set; }
        public string Owner { get; set; }
    }
}
