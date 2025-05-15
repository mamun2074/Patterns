namespace Patterns.SlidingWindows.DynamicSize;

public class ContainDuplicate
{
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int leftPointer=0; 
        int rightPointer=0;
        bool ans=false;
        while(rightPointer<nums.Length)
        {
            if(leftPointer == rightPointer)
            {
                rightPointer++;
                continue; 
            }
            int differentIndex= Math.Abs(leftPointer-rightPointer);
            if(differentIndex > k)
            {
                leftPointer++;
                rightPointer=leftPointer;
                continue;
            }
            
            if(nums[leftPointer] == nums[rightPointer] ){
                ans=true;
                break;
            }else{
                rightPointer++;
            }
            
            if(rightPointer==nums.Length)
            {
                leftPointer++;
                rightPointer=leftPointer;
            }
            
        }
        return ans;
    }
}