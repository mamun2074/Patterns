namespace Patterns.Algorithms.Heap;

public class MinHeap<T> : HeapBase<T> where T : IComparable<T>
{
    protected override void HeapifyUp(int index)
    {
        while (HasParent(index) && GetParent(index).CompareTo(_items[index]) > 0)
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
            int smallChildIndex = GetRightChildIndex(index);
            if (HasRightChild(index) && GetLeftChild(index).CompareTo(_items[smallChildIndex]) < 0)
            {
                smallChildIndex = GetLeftChildIndex(index);
            }

            if (GetParentIndex(index).CompareTo(_items[smallChildIndex]) > 0)
            {
                Swap(index, smallChildIndex);
                index = smallChildIndex;
            }
            else
            {
                break;
            }
        }
    }
}