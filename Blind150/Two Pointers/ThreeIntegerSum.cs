namespace Blind150.Two_Pointers;

public class ThreeIntegerSum
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<int> numsSorted = new List<int>(nums);
        numsSorted.Sort();
        List<List<int>> result = new List<List<int>>();
        for (int i = 0; i < numsSorted.Count; i++)
        {
            int left = i + 1, right = numsSorted.Count - 1;
            
            while (left < right)
            {
                var rightVal = -numsSorted[left] - numsSorted[i];
                var newRight = Find(numsSorted, rightVal, left + 1, right);
                if (newRight > 0)
                {
                    result.Add(new List<int>(){numsSorted[i], numsSorted[left], numsSorted[newRight]});
                    right = newRight;
                    
                    while (right > 0 && numsSorted[right] == numsSorted[right - 1])
                        --right;
                    --right;
                }
                
                while (left < numsSorted.Count - 1 && numsSorted[left] == numsSorted[left + 1])
                    ++left;
                ++left;
            }

            while (i < numsSorted.Count - 1 && numsSorted[i] == numsSorted[i + 1])
                ++i;
        }

        return result;
    }
    
    public int Find(List<int> numbers, int target, int left, int right)
    {
        if (right < left)
            return -1;
        else if (right == left)
            return target == numbers[left] ? left : -1;
        else
        {
            int mid = (left + right) / 2;
            if (numbers[mid] == target)
                return mid;
            else if (numbers[mid] < target)
                return Find(numbers, target, mid + 1, right);
            else
                return Find(numbers, target, left, mid);
        }
    }

}