using System;
using AddAuthLater.Areas.Identity.Data;
using AddAuthLater.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AddAuthLater.Areas.Identity.IdentityHostingStartup))]
namespace AddAuthLater.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AddAuthLaterContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("AddAuthLaterContextConnection")));

                services.AddDefaultIdentity<AddAuthLaterUser>()
                    .AddEntityFrameworkStores<AddAuthLaterContext>();
            });
        }
    }
}