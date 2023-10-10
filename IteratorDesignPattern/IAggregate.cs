namespace IteratorDesignPattern;

internal interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}