using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Smb.Server.DependencyInjection.Configuration.Options;
using Smb.Server.Hosting;

namespace Smb.Server.DependencyInjection.Configuration
{
    public static class SMBServerBuilderExtensions
    {
        public static ISMBServerBuilder AddRequiredPlatformServices(this ISMBServerBuilder builder)
        {
            builder.Services.TryAddSingleton<ISMBServer, SMBServer>();
            builder.Services.AddOptions();
            builder.Services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<SMBServerOptions>>().Value);
            return builder;
        }
    }
}
