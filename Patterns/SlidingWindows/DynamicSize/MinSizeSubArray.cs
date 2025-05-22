namespace Patterns.SlidingWindows.DynamicSize;

public class MinSizeSubArray
{
    private int[] prefixSum;

    public int MinSubArrayLen(int target, int[] nums)
    {
        PrifixSum(nums);
        if (GetSum(0, nums.Length - 1) < target) return 0;
        
        int minLength = Int32.MaxValue;
        int leftWindow = 0;
        int rightWindow = 0;
        
        while (rightWindow < nums.Length)
        {
            int currentSum = GetSum(leftWindow, rightWindow);
            int currentIndexLen = rightWindow - leftWindow + 1;
            if (target <= currentSum)
            {
                minLength = Math.Min(minLength, currentIndexLen);
                leftWindow++;
            }
            else
            {
                rightWindow++;
            }
        }

        return minLength;
    }

    public void PrifixSum(int[] nums)
    {
        int len = nums.Length;
        prefixSum = new int[len];
        prefixSum[0] = nums[0];
        for (int i = 1; i < len; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + nums[i];
        }
    }

    public int GetSum(int i, int j)
    {
        if (i == 0)
        {
            return prefixSum[j];
        }
        else
        {
            return prefixSum[j] - prefixSum[i - 1];
        }
    }
}