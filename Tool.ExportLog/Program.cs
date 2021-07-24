using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Tool.ExportLog.Shared;

namespace Tool.ExportLog
{
    class Program
    {
        public static IConfigurationRoot Configuration;

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var services = new ServiceCollection();

            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(AppContext.BaseDirectory))
                .AddJsonFile("appsettings.json", optional: true);

            Configuration = builder.Build();

            services.AddTransient<IExportService, ExportService>();

            var serviceProvider = services.BuildServiceProvider();

            var exportService = serviceProvider.GetRequiredService<IExportService>();

            // check exist folder
            string folder = Configuration.GetSection("apppath").Value;
            if (!System.IO.Directory.Exists(folder))
            {
                Console.WriteLine("Folder not exist!");
                Console.ReadLine();
                return;
            }

            while (true)
            {
                Console.WriteLine("Export from (yyyymmdd) = ");
                var from = Console.ReadLine();
                if (from.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                Console.WriteLine("Export to (yyyymmdd) = ");
                var to = Console.ReadLine();

                DateTime StartDate = DateTime.ParseExact(from, "yyyyMMdd", CultureInfo.InvariantCulture);
                DateTime EndDate = DateTime.ParseExact(to, "yyyyMMdd", CultureInfo.InvariantCulture);

                foreach (DateTime day in Helper.EachDay(StartDate, EndDate))
                {
                    var ExportAt = "Export At " + System.DateTime.Now.ToString("dd/MM/yyyy, hh:mm:ss");
                    Console.WriteLine(ExportAt);
                    var searchPattern = day.ToString("yyyyMMdd");
                    var lines = exportService.GetAllLines(folder, searchPattern);
                    Console.WriteLine($"Total row: {lines}");
                    var output = exportService.ReadLines("output");
                    Console.WriteLine(output);
                    var ExportEnd = "Export End " + System.DateTime.Now.ToString("dd/MM/yyyy, hh:mm:ss");
                    Console.WriteLine(ExportEnd);
                }

                Console.WriteLine("Input 'exit' to close program!");
                Console.ReadLine();
            }

        }



    }
}
