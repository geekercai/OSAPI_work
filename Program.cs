using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetDimension.NanUI;

namespace OSAPI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            WinFormium.CreateRuntimeBuilder(buildChromiumEnvironment: env =>
            {
                env.CustomCefSettings(settings =>
                {
                    // �ڴ˴����� CEF ����ز���
                });

                env.CustomCefCommandLineArguments(commandLine =>
                {
                    // �ڴ˴�ָ�� CEF �����в���
                });

            }, buildApplicationConfiguration: app =>
            {
                // ָ����������
                app.UseEmbeddedFileResource("http", "static.app.local", "wwwroot");
                app.UseDataServiceResource("http", "api.app.local");
                app.UseMainWindow(context => new MainWindow());
            })
        .Build()
        .Run();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
