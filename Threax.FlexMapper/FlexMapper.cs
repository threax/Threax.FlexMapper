using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Threax.FlexMapper
{
    public class FlexMapper : IFlexMapper
    {
        private IServiceProvider serviceProvider;
        private IMapper mapper;

        public FlexMapper(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.mapper = serviceProvider.GetRequiredService<IMapper>();
        }

        public TOut Map<TIn, TOut>(TIn inVal)
        {
            var service = serviceProvider.GetRequiredService<IFlexTypeMapper<TIn, TOut>>();
            return service.Map(inVal);
        }

        public TOut Map<TIn, TOut>(TIn inVal, TOut outVal)
        {
            var service = serviceProvider.GetRequiredService<IFlexTypeMapper<TIn, TOut>>();
            return service.Map(inVal, outVal);
        }
    }
}
