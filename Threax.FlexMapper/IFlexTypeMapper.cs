using System;
using System.Collections.Generic;
using System.Text;

namespace Threax.FlexMapper
{
    public interface IFlexTypeMapper<TIn, TOut>
    {
        TOut Map(TIn value);

        TOut Map(TIn inVal, TOut outVal);
    }
}
