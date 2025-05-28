namespace Patterns.Algorithms.Heap;

public class MinHeap<T> : HeapBase<T> where T : IComparable<T>
{
    protected override void HeapifyUp(int index)
    {
        while (HasParent(index) && _items[index].CompareTo(GetParent(index)) < 0)
        {
            int parentIndex = GetParentIndex(index);
            Swap(index, parentIndex);
            index = parentIndex;
        }
    }

    protected override void HeapifyDown(int index)
    {
        while (HasLeftChild(index))
        {
            int smallChildIndex = GetLeftChildIndex(index);
            if (HasRightChild(index) && GetLeftChild(index).CompareTo(GetRightChild(index)) < 0)
            {
                smallChildIndex = GetRightChildIndex(index);
            }

            if (_items[index].CompareTo(_items[smallChildIndex]) <= 0)
            {
                break;
            }

            Swap(index, smallChildIndex);
            index = smallChildIndex;
        }
    }
}