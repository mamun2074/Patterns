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

ContainDuplicate containDuplicate = new ContainDuplicate();
int[] arr = { 1,2,3,4,5,6,7,8,9,9 };
bool x = containDuplicate.ContainsNearbyDuplicate(arr, 3);
Console.WriteLine(x);