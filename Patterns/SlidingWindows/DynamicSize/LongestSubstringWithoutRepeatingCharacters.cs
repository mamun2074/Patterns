namespace Patterns.SlidingWindows.DynamicSize;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LongestSubstringWithoutRepeatingCharactersBruit(string sr)
    {
        int maxLength = 0;
        for (int i = 0; i < sr.Length; i++)
        {
            int[] shashTechnique = new int[256];
            for (int j = i; j < sr.Length; j++)
            {
                if (shashTechnique[sr[j]] == 1) break;

                shashTechnique[sr[j]] = 1;
                int len = j - i + 1;
                maxLength = Math.Max(len, maxLength);
            }
        }

        return maxLength;
    }

    public int LongestSubstringWithoutRepeatingCharactersSlidingPointer(string sr)
    {
        int[] shashTechnique = new int[256];
        for (int i = 0; i < 256; i++)
        {
            shashTechnique[i] = -1;
        }

        int leftPointer = 0;
        int rightPointer = 0;
        int length = sr.Length;
        int maxLength = 0;
        while (rightPointer < length)
        {
            if (shashTechnique[sr[rightPointer]] != -1)
            {
                if (shashTechnique[sr[rightPointer]] >= leftPointer)
                {
                    leftPointer = shashTechnique[sr[rightPointer]] + 1;
                }
            }
            
            int tempLen = rightPointer - leftPointer + 1;
            maxLength = Math.Max(tempLen, maxLength);
            shashTechnique[sr[rightPointer]] = rightPointer;
            rightPointer++;
        }

        return maxLength;
    }
}