using DIDemoLib;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
                .ConfigureServices((_, services) =>
                {
                    services
                        .AddTransient<IMessages, Messages>()
                        .AddTransient<Form1>();
                    
                });

            var host = builder.Build();
            using var scope = host.Services.CreateScope();

            try
            {
                var services = scope.ServiceProvider;

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var frm = services.GetRequiredService<Form1>();
                Application.Run(frm);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured: { ex.Message }");
            }
        }
    }
}
