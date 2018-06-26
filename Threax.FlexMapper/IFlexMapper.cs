namespace Threax.FlexMapper
{
    public interface IFlexMapper
    {
        TOut Map<TIn, TOut>(TIn inVal);
        TOut Map<TIn, TOut>(TIn inVal, TOut outVal);
    }
}