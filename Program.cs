using System;
using Microsoft.Win32;

namespace Chronicle.PostInstall
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Chronicle Post-Install");
            Console.WriteLine("Setting Client ID");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ChronicleSoftware", "clientID", Guid.NewGuid().ToString());

            Console.Write("Authentication Server: ");
            string authServer = Console.ReadLine() ?? "";
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\ChronicleSoftware", "AuthServer", authServer);

            Console.WriteLine("Configuration Complete! Press any key to Exit.");
            Console.ReadKey();

        }
    }
}