using DIDemoLib;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IMessages _messages;

        public Worker(ILogger<Worker> logger, IMessages messages)
        {
            _logger = logger;
            _messages = messages;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogError(_messages.SayHello());
                _logger.LogError(_messages.SayGoodBye());
                await Task.Delay(3000, stoppingToken);
            }
        }
    }
}
