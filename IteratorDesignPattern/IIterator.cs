namespace IteratorDesignPattern;

internal interface IIterator<T>
{
    bool HasNext();

    T Next();
}