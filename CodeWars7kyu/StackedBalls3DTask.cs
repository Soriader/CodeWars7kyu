namespace CodeWars7kyu;

public class StackedBalls3DTask
{
    public static double StackHeight3d(int layers)
    {
        if (layers == 0)
        {
            return 0d;
        }
        
        return 1.0 + (layers - 1) * (Math.Sqrt(2) / 2);
    }
}
//https://www.codewars.com/kata/5bb493932ce53339dc0000c2/train/csharp