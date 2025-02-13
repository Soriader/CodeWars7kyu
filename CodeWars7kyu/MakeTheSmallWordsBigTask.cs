namespace CodeWars7kyu;

public class MakeTheSmallWordsBigTask
{
    public static string SmallWordHelper(string sentence)
    {
        string result = "";
        var vovels = "aeiouAEIOU";
        
        var check = sentence.Split(" ");

        foreach (string word in check)
        {
            if (word.Length <= 3)
            {
                result += word.ToUpper();
            }

            if (word.Length > 3)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (vovels.Contains(word[i].ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        result += word[i];
                    }
                }
            }

            result += " ";
        }
        
        result = result.TrimEnd(' ');

        for (int i = sentence.Length - 1; i >= 0; i--)
        {
            if (sentence[i] == ' ')
            {
                result += " ";
            }
            else
            {
                break;
            }
        }
        
        return result;
    }
}
//https://www.codewars.com/kata/57b4dd38d2a31c75f7000299/train/csharp