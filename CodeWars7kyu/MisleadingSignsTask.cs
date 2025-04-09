namespace CodeWars7kyu;

public class MisleadingSignsTask
{
    public static bool Gaslighting(string shirtWord, string yourWord, char[] friendsLetters)
    {
        if (shirtWord == yourWord)
        {
            return false;
        }
        

        for (int i = 0; i < shirtWord.Length; i++)
        {
            if (shirtWord[i] != yourWord[i] 
                && (friendsLetters.Contains(shirtWord[i]) 
                    || friendsLetters.Contains(yourWord[i])))
            {
                return true;
            }
        }
        
        return false;     
    }
}
//https://www.codewars.com/kata/65dd5b414ccda60a4be32c2a/train/csharp