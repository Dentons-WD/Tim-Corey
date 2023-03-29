using System;

namespace BlazorServerDemo.Data
{
    public class Demo : IDemo, ILocalDemo
    {
        public DateTime StartupTime { get; init; }

        public Demo()
        {
            StartupTime = DateTime.Now;
        }
    }
}
