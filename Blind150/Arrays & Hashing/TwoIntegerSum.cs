namespace Blind150.Arrays___Hashing;

public class TwoIntegerSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numsIndexes = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            if (numsIndexes.ContainsKey(target - nums[i]))
                return new int[] { numsIndexes[target - nums[i]], i };
            else
                numsIndexes.TryAdd(nums[i], i);
        }

        return new int[] { -1, -1};
    }
}