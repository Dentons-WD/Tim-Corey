using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BasicDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, builder) => 
                {
                    var memCollection = new Dictionary<string, string>
                    {
                        { "MainSetting:SubSetting", "sub setting from dictionary" }
                    };

                    IHostEnvironment env = hostingContext.HostingEnvironment;
                    builder.Sources.Clear();

                    builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                    builder.AddJsonFile($"appsettings.{ env.EnvironmentName }.json", optional: true, reloadOnChange: true);

                    builder.AddJsonFile("custom.json", optional: true, reloadOnChange: true);

                    builder.AddXmlFile("custom.xml", optional:true, reloadOnChange: true);

                    builder.AddIniFile("custom.ini", optional: true, reloadOnChange: true);

                    builder.AddInMemoryCollection(memCollection);

                    if (hostingContext.HostingEnvironment.IsDevelopment())
                    {
                        builder.AddUserSecrets<Program>();
                    }

                    builder.AddEnvironmentVariables();
                    builder.AddCommandLine(args);
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
