using DIDemoLib;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new HostBuilder()
                .ConfigureAppConfiguration((config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                })
                .ConfigureServices((_, services) =>
                {
                    services
                        .AddTransient<MainWindow>()
                        .AddTransient<IMessages, Messages>();
                });

            var host = builder.Build();

            using var scope = host.Services.CreateScope();
            
            var services = scope.ServiceProvider;

            try
            {
                var frm = services.GetRequiredService<MainWindow>();
                frm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured: { ex.Message }");
            }
        }
    }
}
