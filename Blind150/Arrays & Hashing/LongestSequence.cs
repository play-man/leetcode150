namespace Blind150.Arrays___Hashing;

public class LongestSequence
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> uniqueNumbers = new HashSet<int>(nums);
        if (nums.Length == 0) return 0;
        int result = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            var currentLength = 1;
            var currentNum = nums[i] - 1;
            while (uniqueNumbers.Contains(currentNum))
            {
                currentNum--;
                currentLength++;
            }
            
            if (currentLength > result)
                result = currentLength;
        }

        return result;
    }
}