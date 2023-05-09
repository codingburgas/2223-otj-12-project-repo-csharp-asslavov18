using NutriApp.Forms;
using System.Runtime.CompilerServices;

namespace NutriApp
{
    internal  class Program
    {
        //public static Program ProgramInstance;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormMainMenu());
            Application.Run(new FormLogin());
        }
    }
}