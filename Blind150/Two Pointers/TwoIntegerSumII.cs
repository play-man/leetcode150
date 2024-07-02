namespace Blind150.Two_Pointers;

public class TwoIntegerSumII
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int right = numbers.Length - 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            var find = Find(numbers, target - numbers[i], i + 1, right);
            if (find[0] >= 0)
                return new int[] { i + 1, find[0] + 1};
            else
                right = find[1];
        }

        return new int[] { -1, -1 };
    }
    
    public int[] Find(int[] numbers, int target, int left, int right)
    {
        if (right < left)
            return new int[]{-1, left};
        else if (right == left)
            return new int[]{target == numbers[left] ? left : -1, right};
        else
        {
            int mid = (left + right) / 2;
            if (numbers[mid] == target)
                return new int[]{mid, right};
            else if (numbers[mid] < target)
                return Find(numbers, target, mid + 1, right);
            else
                return Find(numbers, target, left, mid);
        }
    }
}