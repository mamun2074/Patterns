// See https://aka.ms/new-console-template for more information


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


int[] arr = { 1 };
// MinSizeSubArray minSizeSubArray = new MinSizeSubArray();
// int x = minSizeSubArray.MinSubArrayLen(7, arr);

SlidingWindowMax hard = new SlidingWindowMax();
int[] x = hard.MaxSlidingWindow(arr, 1);

Console.WriteLine(x);