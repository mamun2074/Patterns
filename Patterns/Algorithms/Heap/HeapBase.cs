namespace Patterns.Algorithms.Heap;

public abstract class HeapBase<T> where T : IComparable<T>
{
    protected List<T> _items = new List<T>();
    public int Count => _items.Count;

    public T Peek()
    {
        if (_items.Count == 0) throw new InvalidOperationException("Heap is empty");
        return _items[0];
    }
}