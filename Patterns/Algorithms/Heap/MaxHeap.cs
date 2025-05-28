namespace Patterns.Algorithms.Heap;

public class MaxHeap<T> : HeapBase<T> where T : IComparable<T>
{
    protected override void HeapifyUp(int index)
    {
        T parentValue = GetParent(index).value;
        while (HasParent(index) && _items[index].value.CompareTo(parentValue) > 0)
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

            if (HasRightChild(index) && GetLeftChild(index).value.CompareTo(GetRightChild(index).value) < 0)
            {
                smallerChildIndex = GetRightChildIndex(index);
            }


            if (_items[smallerChildIndex].value.CompareTo(_items[index].value) <= 0)
                break;

            Swap(index, smallerChildIndex);
            index = smallerChildIndex;
        }
    }
}