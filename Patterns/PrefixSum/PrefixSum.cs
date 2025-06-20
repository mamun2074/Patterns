namespace Patterns.PrefixSum;

public class PrefixSum
{
    private int[] prefixSum;

    public PrefixSum(int[] nums)
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