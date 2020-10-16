namespace DecoratorPattern
{
    internal abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; }
    }
}