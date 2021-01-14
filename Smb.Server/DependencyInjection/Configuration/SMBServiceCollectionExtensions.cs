using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Smb.Server.DependencyInjection.Configuration.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smb.Server.DependencyInjection.Configuration
{
    public static class SMBServiceCollectionExtensions
    {
        public static ISMBServerBuilder AddSMBServerBuilder(this IServiceCollection services)
        {
            return new SMBServerBuilder(services);
        }

        public static ISMBServerBuilder AddSMBServer(this IServiceCollection services)
        {
            var builder = services.AddSMBServerBuilder();

            builder.AddRequiredPlatformServices();

            return builder;
        }

        public static ISMBServerBuilder AddSMBServer(this IServiceCollection services, Action<SMBServerOptions> setupAction)
        {
            services.Configure<SMBServerOptions>(setupAction);
            return services.AddSMBServer();
        }

        public static ISMBServerBuilder AddSMBServer(this IServiceCollection services, IConfiguration configuration)
        {
            ///Merge with json configuration
            services.Configure<SMBServerOptions>(conf =>
            {
                //conf.Comment 
            });
            return services.AddSMBServer();
        }
    }
}
