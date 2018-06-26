using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Threax.FlexMapper;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddFlexMapper(this IServiceCollection services, Action<FlexMapperOptions> configure = null)
        {
            FlexMapperOptions options = new FlexMapperOptions();
            configure?.Invoke(options);

            services.TryAddScoped<IFlexMapper>(s => new FlexMapper(s));
            services.TryAddScoped(typeof(IFlexTypeMapper<,>), typeof(FlexAutoTypeMapper<,>));

            return services;
        }
    }
}
