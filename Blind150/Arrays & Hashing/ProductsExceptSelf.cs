namespace Blind150.Arrays___Hashing;

public class ProductsExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] asc = Enumerable.Repeat(1, n).ToArray();
        int[] desc = Enumerable.Repeat(1, n).ToArray();
        for (int i = 1; i < nums.Length; i++)
        {
            asc[i] = asc[i - 1] * nums[i - 1];
            desc[n - i - 1] = desc[n - i] * nums[n - i];
        }
        int[] result = new int[n];
        result[0] = desc[0];
        result[n - 1] = asc[n - 1];
        for (int i = 1; i < n - 1; i++)
        {
            result[i] = asc[i] * desc[i];
        }

        return result;
    }
}