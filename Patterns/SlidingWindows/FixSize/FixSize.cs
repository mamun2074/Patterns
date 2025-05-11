namespace Patterns.SlidingWindows.FixSize;

public class FixSize
{
    public int FindMaxSum(int[] arr, int k)
    {
        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += arr[i];
        }

        int leftPointer = 0;
        int tempSum = sum;
        for (int j = k; j < arr.Length; j++)
        {
            tempSum = tempSum - arr[leftPointer++] + arr[j];
            if (sum < tempSum)
            {
                sum = tempSum;
            }
        }

        return sum;
    }
}