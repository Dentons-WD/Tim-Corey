using System;

namespace BlazorServerDemo.Data
{
    public interface IUtcDemo
    {
        DateTime StartupTime { get; init; }
    }
}