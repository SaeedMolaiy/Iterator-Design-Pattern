namespace IteratorDesignPattern;

internal class ConcreteAggregate<T> : IAggregate<T>
{
    private readonly List<T> _items = new();

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public IIterator<T> CreateIterator()
    {
        return new ConcreteIterator<T>(_items);
    }
}
