using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.Security.Credentials;
using WindowsFormsApp3.AccessRoles;

namespace WindowsFormsApp3.Settings_files
{
    public class MicrosoftPassportHelper
    {
        public async Task<bool> MicrosoftPassportAvailableCheckAsync()
        {
            bool keyCredentialAvailable = await KeyCredentialManager.IsSupportedAsync();
            if (keyCredentialAvailable == false)
            {
                Debug.WriteLine("Microsoft Passport is not setup!\nPlease go to Windows Settings and set up a PIN to use it.");
                return false;
            }
            UserModel.Login = "Win_Hello_User";
            UserModel.Password = "";
            UserModel.UserRole = "Admin_Conf";
            UserModel.Access.setAccessDelete(UserModel.UserRole);
            UserModel.Access.setAccessWrite();
            Debug.WriteLine("Microsoft Passport Status: OK");
            return true;
        }
    }
}
