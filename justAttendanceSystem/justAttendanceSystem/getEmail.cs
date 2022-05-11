using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justAttendanceSystem
{
    class getEmail
    {
        private static string user;
        private static string password;

        public static string User { 
            get => user; 
            set => user = value; 
        }
        public static string Password { 
            get => password; 
            set => password = value; 
        }
    }
}
