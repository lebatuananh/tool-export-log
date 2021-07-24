using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.ExportLog.Shared;

namespace Tool.ExportLog.UI
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new form_main());
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IExportService, ExportService>();
            ServiceProvider = services.BuildServiceProvider();
        }
    }


}
