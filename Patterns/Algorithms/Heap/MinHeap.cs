namespace Patterns.Algorithms.Heap;

public class MinHeap<T> : HeapBase<T> where T : IComparable<T>
{
    protected override void HeapifyUp(int index)
    {
        while (HasParent(index) && _items[index].value.CompareTo(GetParent(index).value) < 0)
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
            if (HasRightChild(index) && GetLeftChild(index).value.CompareTo(GetRightChild(index).value) < 0)
            {
                smallChildIndex = GetRightChildIndex(index);
            }

            if (_items[index].value.CompareTo(_items[smallChildIndex].value) <= 0)
            {
                break;
            }

            Swap(index, smallChildIndex);
            index = smallChildIndex;
        }
    }
}