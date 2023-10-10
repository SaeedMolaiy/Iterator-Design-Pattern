using IteratorDesignPattern;

var aggregate = new ConcreteAggregate<string>();
aggregate.AddItem("Item 1");
aggregate.AddItem("Item 2");
aggregate.AddItem("Item 3");

var iterator = aggregate.CreateIterator();

while (iterator.HasNext())
{
    var item = iterator.Next();
    Console.WriteLine(item);
}

Console.ReadKey();