// See https://aka.ms/new-console-template for more information


using Patterns.Algorithms.Heap;
using Patterns.SlidingWindows.DynamicSize;
using Patterns.SlidingWindows.FixSize;

Console.WriteLine("Hello, World!");

// FixSize twoPointer = new FixSize();
//
// int[] arr = { 5, 8, 3, 2, 1, 4, 8, 7 };
// int sum = twoPointer.FindMaxSum(arr, 3);
//

// LongestSubstringWithoutRepeatingCharacters maxBrute = new LongestSubstringWithoutRepeatingCharacters();
//
// string s = "cadbzabcd";
// int x=maxBrute.LongestSubstringWithoutRepeatingCharactersSlidingPointer(s);

// ContainDuplicate containDuplicate = new ContainDuplicate();
// int[] arr = { 2, 3, 1, 2, 4, 3 };
// bool x = containDuplicate.ContainsNearbyDuplicate(arr, 3);


// int[] arr = { 1 };
// MinSizeSubArray minSizeSubArray = new MinSizeSubArray();
// int x = minSizeSubArray.MinSubArrayLen(7, arr);

// SlidingWindowMax hard = new SlidingWindowMax();
// int[] x = hard.MaxSlidingWindow(arr, 1);

MaxHeap<int> maxHeap = new MaxHeap<int>();
KeyValuePair<int> first = new KeyValuePair<int>();
first.index = 0;
first.value = 20;
maxHeap.Insert(first);
first.index = 1;
first.value = 30;
maxHeap.Insert(first);
first.index = 2;
first.value = 15;
maxHeap.Insert(first);
first.index = 3;
first.value = 12;
maxHeap.Insert(first);
first.index = 4;
first.value = 40;
maxHeap.Insert(first);
first.index = 5;
first.value = 25;
maxHeap.Insert(first);
first.index = 6;
first.value = 20;
maxHeap.Insert(first);

KeyValuePair<int>  y = maxHeap.Peek();

maxHeap.Delete();

maxHeap.Delete();


MinHeap<int> minHeap = new MinHeap<int>();
// minHeap.Insert(10);
// minHeap.Insert(5);
// minHeap.Insert(10);
// minHeap.Insert(12);
// minHeap.Insert(40);
// minHeap.Insert(25);
// minHeap.Insert(20);
//
// int p = minHeap.Peek();
//
// minHeap.Delete();
//
// minHeap.Delete();