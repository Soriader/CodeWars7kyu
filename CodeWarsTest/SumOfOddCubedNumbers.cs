using CodeWars7kyu;

namespace CodeWarsTest;

public class SumOfOddCubedNumbers
{
    [Test]
    public void SumOfOddCubedNumbersTest()
    {
        Assert.AreEqual(28, SumOfOddCubedNumbersTask.CubeOdd(new int[] { 1, 2, 3, 4 }));
        Assert.AreEqual(0, SumOfOddCubedNumbersTask.CubeOdd(new int[] { -3, -2, 2, 3 }));
    }
}