using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.AccessRoles
{
    public static class UserModel
    {
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string UserRole { get; set; }
        public static Access Access { get; set; } = new Access();

        public static void EndSession()
        {
            Login = null;
            Password = null;
            Access.setAccessWrite();
            Access.setAccessDelete(UserRole);
            UserRole = null;
        }
    }
}
