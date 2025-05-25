namespace Patterns.Algorithms.Heap;

public abstract class HeapBase<T> where T : IComparable<T>
{
    protected List<T> _items = new List<T>();
    public int _count => _items.Count;

    protected abstract void HeapifyUp(int index);
    protected abstract void HeapifyDown(int index);

    protected int GetParentIndex(int i) => (i - 1) / 2;
    protected int GetLeftChildIndex(int i) => (2 * i + 1);
    protected int GetRightChildIndex(int i) => (2 * i + 2);

    protected bool HasParent(int i) => (i > 0);
    protected bool HasLeftChild(int i) => GetLeftChildIndex(i) < _count;
    protected bool HasRightChild(int i) => GetRightChildIndex(i) < _count;

    protected T GetParent(int i) => _items[GetParentIndex(i)];
    protected T GetLeftChild(int i) => _items[GetLeftChildIndex(i)];
    protected T GetRightChild(int i) => _items[GetRightChildIndex(i)];

    public T Peek()
    {
        if (_items.Count == 0) throw new InvalidOperationException("Heap is empty");
        return _items[0];
    }

    public void Insert(T item)
    {
        _items.Add(item);
        HeapifyUp(_count - 1);
    }

    public void Delete()
    {
        if (_items.Count == 0) throw new InvalidOperationException("Heap is empty");
        _items[0] = _items[_count - 1];
        _items.RemoveAt(_count - 1);
        HeapifyDown(0);
    }

    protected void Swap(int i, int j)
    {
        (_items[i], _items[j]) = (_items[j], _items[i]);
    }
}