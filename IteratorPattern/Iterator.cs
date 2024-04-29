using System.Collections;

namespace IteratorPattern;

public abstract class Iterator : IEnumerator
{
    object IEnumerator.Current => Current();

    protected abstract object Current();
    public abstract bool   MoveNext();
    public abstract void   Reset();
}