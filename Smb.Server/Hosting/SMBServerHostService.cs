using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smb.Server.Hosting
{
    public class SMBServerHostService : IHostedService
    {
        private readonly ILogger logger;
        private readonly ISMBServer smbServer;

        public SMBServerHostService(ILogger<SMBServerHostService> logger, IHostApplicationLifetime appLifetime, ISMBServer smbServer)
        {
            this.logger = logger;
            this.smbServer = smbServer;

            appLifetime.ApplicationStarted.Register(OnStarted);
            appLifetime.ApplicationStopping.Register(OnStopping);
            appLifetime.ApplicationStopped.Register(OnStopped);
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("1. StartAsync has been called.");

            smbServer.Start();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("4. StopAsync has been called.");

            return Task.CompletedTask;
        }

        private void OnStarted()
        {
            logger.LogInformation("2. OnStarted has been called.");
        }

        private void OnStopping()
        {
            logger.LogInformation("3. OnStopping has been called.");
        }

        private void OnStopped()
        {
            logger.LogInformation("5. OnStopped has been called.");
        }
    }
}
