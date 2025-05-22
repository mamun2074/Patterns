namespace Patterns.SlidingWindows.DynamicSize;

public class ContainDuplicateHard
{
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < i + 1 + indexDiff; j++)
            {
                if (j >= n) break;
                if (Math.Abs(nums[i] - nums[j]) <= valueDiff) return true;
            }
        }

        return false;
    }
}