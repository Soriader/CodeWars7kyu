namespace CodeWars7kyu;

public class PasswordValidatorTask
{
    public static bool Password(string st)
    {
        if (st.Length < 8 
            ||!st.ToCharArray().Any(c => char.IsLower(c))
            ||!st.ToCharArray().Any(c => char.IsUpper(c))
            ||!st.ToCharArray().Any(c => char.IsDigit(c)))
        {
            return false;
        }
        
        return true;
    }
}
//https://www.codewars.com/kata/56a921fa8c5167d8e7000053/train/csharp