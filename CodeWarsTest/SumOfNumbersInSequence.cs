using CodeWars7kyu;

namespace CodeWarsTest;

public class SumOfNumbersInSequence
{
    [Test]
    public void SumOfNumbersInSequenceTest()
    {
        Assert.AreEqual(1, SumOfNumbersInSequenceTask.GetSum(0, 1));
        Assert.AreEqual(-1, SumOfNumbersInSequenceTask.GetSum(0, -1));
    }
}