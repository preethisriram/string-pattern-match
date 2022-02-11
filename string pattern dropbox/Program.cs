// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static bool patternMatch(String str, String pattern)
{
    
    String[] splitstr = str.Split(" ");

    char[] patternchar = pattern.ToArray();
    HashSet<String> words = new HashSet<String>();

    if (splitstr.Length != patternchar.Length)
        return false;

    Dictionary<char, string> pattmatch = new Dictionary<char, string>();

    for(int i = 0;i<pattern.Length;i++)
    {
        if(pattmatch.ContainsKey(pattern[i]))
        {
            var currword = pattmatch[pattern[i]];
            if (currword != splitstr[i])
                return false;
        }
        else
        {
            if(words.Contains(splitstr[i]))
                return false;
            pattmatch.Add(pattern[i],splitstr[i]);
            words.Add(splitstr[i]);
        }
    }

    return true;




}


String str = "red blue green red red";
String pattern = "abcaa";
bool res = patternMatch(str, pattern);
Console.WriteLine(res);