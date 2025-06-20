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

// MaxHeap<int> maxHeap = new MaxHeap<int>();
// KeyValuePair<int> first = new KeyValuePair<int>();
// first.index = 0;
// first.value = 20;
// maxHeap.Insert(first);
// KeyValuePair<int> second = new KeyValuePair<int>();
// second.index = 1;
// second.value = 30;
// maxHeap.Insert(second);
// KeyValuePair<int> third = new KeyValuePair<int>();
// third.index = 2;
// third.value = 15;
// maxHeap.Insert(third);
// KeyValuePair<int> forth = new KeyValuePair<int>();
// forth.index = 3;
// forth.value = 50;
// maxHeap.Insert(forth);
//
// KeyValuePair<int> y = maxHeap.Peek();
//
// maxHeap.Delete();
//
// maxHeap.Delete();


Solution solution = new Solution();
int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
solution.MaxSlidingWindow(arr, 3);