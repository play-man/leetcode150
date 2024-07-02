namespace Blind150.Two_Pointers;

public class MaxWaterContainer
{
    public int MaxArea(int[] heights)
    {
        int result = 0;
        int left = 0, right = heights.Length - 1;
        while (left < right)
        {
            int area = Math.Min(heights[left], heights[right]) * (right - left);
            if (area > result)
                result = area;

            if (heights[left] < heights[right])
                left++;
            else
                right--;
        }
        return result;
    }
}