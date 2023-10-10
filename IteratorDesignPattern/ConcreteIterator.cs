namespace IteratorDesignPattern;

internal class ConcreteIterator<T> : IIterator<T>
{
    private readonly List<T> _items;
    private int _position;

    public ConcreteIterator(List<T> items)
    {
        _items = items;
    }

    public bool HasNext()
    {
        return _position < _items.Count;
    }

    public T Next()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException("No more elements in the collection.");
        }

        var item = _items[_position];
        _position++;
        return item;
    }
}