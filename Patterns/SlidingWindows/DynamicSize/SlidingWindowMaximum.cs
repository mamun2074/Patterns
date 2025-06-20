namespace Patterns.SlidingWindows.DynamicSize;

public class Solution {

    public class KeyValuePair<T>
    {
        public T index { get; set; }
        public T value { get; set; }
    }

    public abstract class HeapBase<T> where T : IComparable<T>
    {
        protected List<KeyValuePair<T>> _items = new List<KeyValuePair<T>>();
        public int _count => _items.Count;

        protected abstract void HeapifyUp(int index);
        protected abstract void HeapifyDown(int index);

        protected int GetParentIndex(int i) => (i - 1) / 2;
        protected int GetLeftChildIndex(int i) => (2 * i + 1);
        protected int GetRightChildIndex(int i) => (2 * i + 2);

        protected bool HasParent(int i) => (i > 0);
        protected bool HasLeftChild(int i) => GetLeftChildIndex(i) < _count;
        protected bool HasRightChild(int i) => GetRightChildIndex(i) < _count;

        protected KeyValuePair<T> GetParent(int i) => _items[GetParentIndex(i)];
        protected KeyValuePair<T> GetLeftChild(int i) => _items[GetLeftChildIndex(i)];
        protected KeyValuePair<T> GetRightChild(int i) => _items[GetRightChildIndex(i)];

        public KeyValuePair<T> Peek()
        {
            if (_items.Count == 0) throw new InvalidOperationException("Heap is empty");
            return _items[0];
        }

        public void Insert(KeyValuePair<T> item)
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

    public class MaxHeap<T> : HeapBase<T> where T : IComparable<T>
    {
        protected override void HeapifyUp(int index)
        {
            while (HasParent(index) && _items[index].value.CompareTo(GetParent(index).value) > 0)
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


    public int[] MaxSlidingWindow(int[] nums, int k) {
        int len=nums.Length;
        int[] output= new int[len-k+1];
        MaxHeap<int> maxHeap = new MaxHeap<int>();
        for(int i=0; i<k; i++)
        {
            KeyValuePair<int> item = new KeyValuePair<int>();
            item.index = i;
            item.value = nums[i];
            maxHeap.Insert(item);
        }
        KeyValuePair<int> pair = maxHeap.Peek();
        output[0]=pair.value;

        for(int j=1; j<=len-k; j++)
        {
            KeyValuePair<int> first = new KeyValuePair<int>();
            first.index = j+k-1;
            first.value = nums[j+k-1];
            maxHeap.Insert(first);
            KeyValuePair<int> newPair = maxHeap.Peek();
            if(newPair.index < j)
            {
                maxHeap.Delete();
                newPair = maxHeap.Peek();
            }
            output[j]=newPair.value;
        }

        return output;
    }
}