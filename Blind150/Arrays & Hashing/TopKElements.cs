namespace Blind150.Arrays___Hashing;

public class TopKElements
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var frequencies = nums.GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());

        var frequenciesTransposed = new List<HashSet<int>>(nums.Length + 1);
        for (int i = 0; i < nums.Length + 1; i++)
        {
            frequenciesTransposed.Add(new HashSet<int>());
        }
        foreach (var f in frequencies)
            frequenciesTransposed[f.Value].Add(f.Key);
        
        HashSet<int> result = new HashSet<int>();
        for (int i = nums.Length; i >= 0; --i)
        {
            foreach (var d in frequenciesTransposed[i])
                if (result.Count() < k)
                    result.Add(d);
        }

        return result.ToArray();
    }
}