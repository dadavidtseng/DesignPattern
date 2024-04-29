namespace IteratorPattern;

public class AlphabeticalOrderIterator : Iterator
{
    private readonly WordsCollection _collection;
    private readonly bool            _reverse;
    private          int             _position = -1;

    public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
    {
        _collection = collection;
        _reverse    = reverse;

        if (reverse)
            _position = collection.GetItems().Count;
    }

    protected override object Current() => _collection.GetItems()[_position];

    public override bool MoveNext()
    {
        var updatedPosition = _position + (_reverse ? -1 : 1);
        
        if (updatedPosition < 0 || updatedPosition >= _collection.GetItems().Count)
            return false;

        _position = updatedPosition;

        return true;
    }

    public override void Reset() => _position = _reverse ? _collection.GetItems().Count - 1 : 0;
}