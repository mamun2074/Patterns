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
}