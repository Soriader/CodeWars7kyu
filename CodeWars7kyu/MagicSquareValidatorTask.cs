namespace CodeWars7kyu;

public class MagicSquareValidatorTask
{
    public static bool IsMagical(int[] square)
    {
        if (square.Length != 9)
        {
            return false;
        }

        if (square.Distinct().Count() != 9)
        {
            return false;
        }

        if (square[0] + square[1] + square[2] != 15 ||
            square[3] + square[4] + square[5] != 15 ||
            square[6] + square[7] + square[8] != 15)
        {
            return false;
        }

        if (square[0] + square[3] + square[6] != 15 ||
            square[1] + square[4] + square[7] != 15 ||
            square[2] + square[5] + square[8] != 15)
        {
            return false;
        }

        if (square[0] + square[4] + square[8] != 15 ||
            square[2] + square[4] + square[6] != 15)
        {
            return false;
        }

        return true;
    }

}
//https://www.codewars.com/kata/57be6a612eaf7cc3af000178/train/csharp