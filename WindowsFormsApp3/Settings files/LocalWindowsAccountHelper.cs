using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.AccessRoles;

namespace WindowsFormsApp3.Settings_files
{
    public class LocalWindowsAccountHelper
    {

        [DllImport("advapi32.dll")]
        public static extern bool LogonUser(string name,
            string domain, string pass, int logType, int logpv, ref IntPtr pht);

        public bool LocalWindowsAvailableCheckAsync(string login, string pass)
        {
            IntPtr th = IntPtr.Zero;
            bool log = LogonUser(login, "workgroup", pass, 2, 0, ref th);
            if (log)
            {
                UserModel.Login = login;
                UserModel.Password = "";
                UserModel.UserRole = "Admin";
                UserModel.Access.Write = true;
                UserModel.Access.Read = true;
                UserModel.Access.Delete = false;
                Debug.WriteLine("Local Passport Status: OK");
                return true;
            }
            else
            {
                Debug.WriteLine("Local Passport Status: Error.\nInvalid username or password");
                return false;
            }
        }
    }
}
