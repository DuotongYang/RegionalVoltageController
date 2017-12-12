// COMPILER GENERATED CODE
// THIS WILL BE OVERWRITTEN AT EACH GENERATION
// EDIT AT YOUR OWN RISK

using System;
using System.Windows.Forms;
using ECAClientFramework;
using ECAClientUtilities.API;

namespace RVC118
{
    static class Program
    {
        /// <summary>
        /// Main entry point for RVC118.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Algorithm.UpdateSystemSettings();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Framework framework = FrameworkFactory.Create();
            Algorithm.API = new Hub(framework);

            MainWindow mainWindow = new MainWindow(framework);
            mainWindow.Text = "C# RVC118 Test Harness";
            Application.Run(mainWindow);
        }
    }
}