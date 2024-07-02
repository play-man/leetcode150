namespace Blind150.Two_Pointers;

public class TrappingRainWater
{
    public int Trap(int[] height)
    {
        int left = 0, right = height.Length - 1;
        int waterLevel = 0, waterAmount = 0, lower = 0;
        while (left < right)
        {
            lower = height[left] < height[right] ? height[left] : height[right];
            if (height[left] < height[right])
                left++;
            else
                right--;
            waterLevel = Math.Max(lower, waterLevel);
            waterAmount += waterLevel - lower;
        }

        return waterAmount;
    }
}