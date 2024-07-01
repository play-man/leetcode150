namespace Blind150.Arrays___Hashing;

public class AnagramGroups
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        List<List<string>> result = new List<List<string>>();
        if (strs.Length > 0)
            result.Add(new List<string>{strs[0]});
        for (int i = 1; i < strs.Length; i++)
        {
            bool isAnagram = false;
            foreach (var t in result)
                if (IsAnagram(t[0], strs[i]))
                {
                    t.Add(strs[i]);
                    isAnagram = true;
                    break;
                }
            if (!isAnagram)
                result.Add(new List<string>{strs[i]});
        }

        return result;
    }
    
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