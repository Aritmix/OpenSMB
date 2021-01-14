using Microsoft.Extensions.DependencyInjection;
using System;

namespace Smb.Server.DependencyInjection.Configuration
{
    public class SMBServerBuilder : ISMBServerBuilder
    {
        public SMBServerBuilder(IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }

        public IServiceCollection Services { get; }
    }
}
