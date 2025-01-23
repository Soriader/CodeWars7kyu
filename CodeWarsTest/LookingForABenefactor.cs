using CodeWars7kyu;

namespace CodeWarsTest;

public class LookingForABenefactor
{
    [Test]
    public static void LookingForABenefactorTest()
    {
        static void Testing(long actual, long expected)
        {
            Assert.AreEqual(expected, actual);
        }

        double[] a = new double[] { 14, 30, 5, 7, 9, 11, 15 };
        Testing(LookingForABenefactorTask.NewAvg(a, 100), 709);
        a = new double[] { 14.0, 30.0, 5.0, 7.0, 9.0, 11.0, 16.0 };
        Testing(LookingForABenefactorTask.NewAvg(a, 90), 628);
    }
}