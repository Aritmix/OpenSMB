using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Smb.Server.DependencyInjection.Configuration.Options;
using Smb.Server.Extensions;
using Smb.Server.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Smb.Server.DependencyInjection.Configuration
{
    public static class SMBServerServiceCollectionHostedServiceExtensions
    {
        public static IServiceCollection AddHostedSMBService<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] THostedService>(this IServiceCollection services) where THostedService : class, IHostedService
        {
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IHostedService, THostedService>());
            services.AddSMBServer();
            return services;
        }

        public static IServiceCollection AddHostedSMBService<THostedService>(this IServiceCollection services, Func<IServiceProvider, THostedService> implementationFactory)
        where THostedService : class, IHostedService
        {
            services.TryAddEnumerable(ServiceDescriptor.Singleton<IHostedService>(implementationFactory));

            return services;
        }
    }
}
