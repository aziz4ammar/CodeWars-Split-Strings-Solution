using System.Collections.Generic;

public class SplitString
{
    public static string[] Solution(string str)
    {
        if (str.Length % 2 != 0)
            str += "_"; // Append an underscore if the string length is odd
        
        List<string> result = new List<string>();
        
        for (int i = 0; i < str.Length; i += 2)
        {
            string pair = str.Substring(i, 2);
            result.Add(pair);
        }
        
        return result.ToArray();
    }
}
