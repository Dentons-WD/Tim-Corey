﻿using System;

namespace BlazorServerDemo.Data
{
    public interface IDemo
    {
        DateTime StartupTime { get; init; }
    }

    public interface IUtcDemo
    {
        DateTime StartupTime { get; init; }
    }
}