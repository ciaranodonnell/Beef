/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using Beef.Data.Database.Cdc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Beef.Demo.CdcPublisher.Services
{
    /// <summary>
    /// Provides the generated <see cref="CdcHostedService"/> extensions.
    /// </summary>
    public static class CdcHostedServiceExtensions
    {
        /// <summary>
        /// Adds the generated CDC hosted services.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/>.</param>
        /// <param name="config">The <see cref="IConfiguration"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/>.</returns>
        public static IServiceCollection AddGeneratedCdcHostedServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddCdcHostedService<ContactCdcHostedService>(config);
            services.AddCdcHostedService<PostsCdcHostedService>(config);
            services.AddCdcHostedService<PersonCdcHostedService>(config);
            return services;
        }
    }
}

#pragma warning restore
#nullable restore