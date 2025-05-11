// See https://aka.ms/new-console-template for more information


using Patterns.SlidingWindows.FixSize;

Console.WriteLine("Hello, World!");

FixSize twoPointer = new FixSize();

int[] arr = { 5, 8, 3, 2, 1, 4, 8, 7 };
int sum = twoPointer.FindMaxSum(arr, 3);

Console.WriteLine(sum);