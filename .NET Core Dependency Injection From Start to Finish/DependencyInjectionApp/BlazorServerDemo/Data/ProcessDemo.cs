using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace BlazorServerDemo.Data
{
    public class ProcessDemo
    {
        //private readonly IServiceProvider _service;

        private readonly IDemo _demo;

        public int AnotherNumber { get; set; } = 3;

        //public ProcessDemo(IServiceProvider service)
        public ProcessDemo(IDemo demo, int anotherNumber = 5)
        {
            //_service = service;
            _demo = demo;
            AnotherNumber = anotherNumber;
        }

        //public ProcessDemo(IDemo demo)
        //{
        //    //_service = service;
        //    _demo = demo;
        //}

        public int GetDaysInMonth()
        {
            //IDemo _demo = _service.GetRequiredService<IDemo>();
            return _demo.StartupTime.Month switch
            {
                1 => 31,
                2 => (_demo.StartupTime.Year % 4 == 0) ? 29 : 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => throw new IndexOutOfRangeException()
            };
        }
    }
}
