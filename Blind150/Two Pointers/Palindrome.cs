namespace Blind150.Two_Pointers;

public class Palindrome
{
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;
        bool result = true;
        while (left < right && left < s.Length && right >= 0)
        {
            while (!Char.IsLetterOrDigit(s[left]) && left < s.Length - 1)
                left++;
            
            while (!Char.IsLetterOrDigit(s[right]) && right > 0)
                right--;

            if (left <= right
                && Char.ToLowerInvariant(s[left]) != Char.ToLowerInvariant(s[right]))
            {
                result = false;
                break;
            }
            left++;
            right--;
        }

        return result;
        
    }
}