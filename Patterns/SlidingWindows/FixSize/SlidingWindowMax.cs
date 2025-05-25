namespace Patterns.SlidingWindows.FixSize;

public class SlidingWindowMax
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int len = nums.Length;
        int[] output = new int[len-k+1];
        for (int l = 0; l < len; l++)
        {
            int max = nums[l];
            for (int r = l + 1; r < k; r++)
            {
                if (nums[r] > max)
                {
                    max = nums[r];
                }
            }

            output[l] = max;
            k++;
            if (len < k) break;
        }

        return output;
    }
}