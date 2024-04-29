using System.Collections;

namespace IteratorPattern;

public class WordsCollection : IteratorAggregate
{
    private readonly List<string> _collection = [];
    private          bool         _direction;

    public          List<string> GetItems()           => _collection;
    public          void         AddItem(string item) => _collection.Add(item);
    public          void         ReverseDirection()   => _direction = !_direction;
    public override IEnumerator  GetEnumerator()      => new AlphabeticalOrderIterator(this, _direction);
}