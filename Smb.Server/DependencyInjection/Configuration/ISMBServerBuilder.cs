using Microsoft.Extensions.DependencyInjection;

namespace Smb.Server.DependencyInjection.Configuration
{
    public interface ISMBServerBuilder
    {
        IServiceCollection Services { get; }
    }
}
