using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Smb.Server.DependencyInjection.Services
{
    public interface ICache<T> where T : class
    {
        Task<T> GetAsync(string key);
        Task<T> GetAsync(string key, Action<T> cacheMiss);
        Task SetAsync(string key, T item, TimeSpan expiration);
    }
}
