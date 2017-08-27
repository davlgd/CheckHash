using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace CheckHash
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RegistryKey subkey = Registry.CurrentUser.CreateSubKey(@"Software\Classes\*\shell\Calculer l'empreinte\command");
            subkey.SetValue("", Application.ExecutablePath + " \"%1\"");
            subkey.Close();

            Application.Run(new Form1(args));
        }
    }
}
