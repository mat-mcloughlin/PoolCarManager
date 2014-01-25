using System;
using System.Reflection;
using System.Windows.Forms;
using PoolCarManager.Core.Commands;

namespace PoolCarManager.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CommandProcessor.AddCommandHandlerAssembly(Assembly.GetExecutingAssembly());

            Application.Run(new MainForm());
        }
    }
}
