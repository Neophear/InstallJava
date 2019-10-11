using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallJava
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Security.SecureString password = new System.Security.SecureString();
            foreach (char character in "d12345**")
            {
                password.AppendChar(character);
            }

            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WorkingDirectory = "\\\\10.10.10.10\\Java_til_Bruger\\",
                FileName = "calc.exe",
                UserName = "diablo",
                Password = password,
                Domain = "INTERNET.LOCAL",
                UseShellExecute = false
            };

            System.Diagnostics.Process.Start(startInfo);
        }
    }
}
