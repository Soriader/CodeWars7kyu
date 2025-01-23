using CodeWars7kyu;

namespace CodeWarsTest;

public class TwoNumbersArePositive
{
    [Test]
    public void TwoNumbersArePositiveTest()
    {
        Assert.AreEqual(true, TwoNumbersArePositiveTask.TwoArePositive(2, 4, -3), "(2, 4, -3)");
        Assert.AreEqual(true, TwoNumbersArePositiveTask.TwoArePositive(-4, 6, 8), "(-4, 6, 8)");
        Assert.AreEqual(true, TwoNumbersArePositiveTask.TwoArePositive(4, -6, 9), "(4, -6, 9)");
        Assert.AreEqual(true, TwoNumbersArePositiveTask.TwoArePositive(4, 6, 0), "(4, 6, 0)");
        Assert.AreEqual(false, TwoNumbersArePositiveTask.TwoArePositive(-4, 6, 0), "(-4, 6, 0)");
        Assert.AreEqual(false, TwoNumbersArePositiveTask.TwoArePositive(4, 6, 10), "(4, 6, 10)");
        Assert.AreEqual(false, TwoNumbersArePositiveTask.TwoArePositive(-14, -3, -4), "(-14, -3, -4)");
    }
}