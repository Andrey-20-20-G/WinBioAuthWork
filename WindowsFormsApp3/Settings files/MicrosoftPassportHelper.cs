using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.Security.Credentials;
using WindowsFormsApp3.AccessRoles;

namespace WindowsFormsApp3.Settings_files
{
    public class MicrosoftPassportHelper
    {
        public async System.Threading.Tasks.Task<bool> CheckFingerprintAvailability()
        {
            bool status = false;

            try
            {
                // Check the availability of fingerprint authentication.
                var ucvAvailability = await Windows.Security.Credentials.UI.UserConsentVerifier.CheckAvailabilityAsync();

                switch (ucvAvailability)
                {
                    case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.Available:
                        Debug.WriteLine("Fingerprint verification is available.");
                        status = true;
                        break;
                    case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.DeviceBusy:
                        Debug.WriteLine("Biometric device is busy.");
                        break;
                    case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.DeviceNotPresent:
                        Debug.WriteLine("No biometric device found.");
                        break;
                    case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.DisabledByPolicy:
                        Debug.WriteLine("Biometric verification is disabled by policy.");
                        break;
                    case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.NotConfiguredForUser:
                        Debug.WriteLine("The user has no fingerprints registered. Please add a fingerprint to the " +
                                        "fingerprint database and try again.");
                        break;
                    default:
                        Debug.WriteLine("Fingerprints verification is currently unavailable.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Fingerprint authentication availability check failed: " + ex.ToString());
            }

            return status;
        }

        public async Task<bool> MicrosoftPassportAvailableCheckAsync()
        {
            bool checkScanner = await CheckFingerprintAvailability();
            if (checkScanner == false)
            {
                Debug.WriteLine("The scanner is currently not working or busy");
                return false;
            }
            bool keyCredentialAvailable = await KeyCredentialManager.IsSupportedAsync();
            if (keyCredentialAvailable == false)
            {
                Debug.WriteLine("Microsoft Passport is not setup!\nPlease go to Windows Settings and set up a PIN to use it.");
                return false;
            }
            UserModel.Login = "Win_Hello_User";
            UserModel.Password = "";
            UserModel.UserRole = "Admin_Conf";
            UserModel.Access.Delete = true;
            UserModel.Access.Write = true;
            UserModel.Access.Read = true;
            Debug.WriteLine("Microsoft Passport Status: OK");
            return true;
        }
    }
}
