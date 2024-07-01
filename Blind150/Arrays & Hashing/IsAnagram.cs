namespace Blind150.Arrays___Hashing;

public class IsAnagramClass
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) 
            return false;
        Dictionary<char, int> charDelta = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!charDelta.TryAdd(s[i], 1))
                charDelta[s[i]] += 1;
            if (!charDelta.TryAdd(t[i], -1))
                charDelta[t[i]] -= 1;
        }
        return charDelta.All(c => c.Value == 0);
    }
}