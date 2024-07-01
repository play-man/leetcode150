namespace Blind150.Arrays___Hashing;

public class ContainsDuplicate
{
    public bool hasDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        return nums.Any(t => !set.Add(t));
    }
    
}