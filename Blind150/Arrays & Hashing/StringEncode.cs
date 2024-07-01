namespace Blind150.Arrays___Hashing;

public class StringEncode
{
    private static readonly char delimeter = ':';
    public string Encode(IList<string> strs)
    {
        return string.Concat(
            strs.SelectMany(x => $"{x.Length}{delimeter}{x}"));
    }

    public List<string> Decode(string s)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < s.Length; i++)
        {
            int delimeterIndex = s.IndexOf(delimeter, i);
            int length = Int32.Parse(s.Substring(i, delimeterIndex - i));
            result.Add(s.Substring(delimeterIndex + 1, length));
            i += (length + delimeterIndex - i);
        }

        return result;
    }
    
}