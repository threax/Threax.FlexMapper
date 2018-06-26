using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Threax.FlexMapper
{
    public class FlexAutoTypeMapper<TIn, TOut> : IFlexTypeMapper<TIn, TOut>
    {
        private IMapper mapper;

        public FlexAutoTypeMapper(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public TOut Map(TIn inVal)
        {
            var ret = mapper.Map<TIn, TOut>(inVal);
            CustomMapping(inVal, ret);
            return ret;
        }

        public TOut Map(TIn inVal, TOut outVal)
        {
            var ret = mapper.Map<TIn, TOut>(inVal, outVal);
            CustomMapping(inVal, ret);
            return ret;
        }

        public virtual void CustomMapping(TIn inVal, TOut outVal)
        {

        }
    }
}
