namespace Patterns.Algorithms.Heap;

public class MaxHeap<T> : HeapBase<T> where T : IComparable<T>
{
    protected override void HeapifyUp(int index)
    {
        while (HasParent(index) && GetParent(index).CompareTo(_items[index]) < 0)
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
            int smallerChildIndex = GetLeftChildIndex(index);

            if (HasRightChild(index) && GetLeftChild(index).CompareTo(GetRightChild(index)) < 0)
            {
                smallerChildIndex = GetRightChildIndex(index);
            }


            if (_items[smallerChildIndex].CompareTo(_items[index]) <= 0)
                break;

            Swap(index, smallerChildIndex);
            index = smallerChildIndex;
        }
    }
}