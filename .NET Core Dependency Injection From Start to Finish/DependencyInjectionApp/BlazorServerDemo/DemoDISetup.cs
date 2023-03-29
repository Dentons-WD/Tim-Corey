using BlazorServerDemo.Data;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorServerDemo
{
    public static class DemoDISetup
    {
        public static IServiceCollection AddDemoInfo(this IServiceCollection services)
        {
            services.AddTransient<IDemo, Demo>();
            services.AddTransient<IDemo, UtcDemo>();
            services.AddTransient<ProcessDemo>();
            //services.AddTransient(x => new ProcessDemo(x.GetRequiredService<IDemo>(), 25));

            return services;
        }
    }
}
