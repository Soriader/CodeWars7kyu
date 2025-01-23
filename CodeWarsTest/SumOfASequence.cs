using CodeWars7kyu;

namespace CodeWarsTest;

public class SumOfASequence
{
    [Test]
    public void SumOfASequenceTest()
    {
        Assert.AreEqual(12, SumOfASequenceTask.SequenceSum(2, 6, 2));
        Assert.AreEqual(15, SumOfASequenceTask.SequenceSum(1, 5, 1));
        Assert.AreEqual(5, SumOfASequenceTask.SequenceSum(1, 5, 3));
        Assert.AreEqual(45, SumOfASequenceTask.SequenceSum(0, 15, 3));
        Assert.AreEqual(0, SumOfASequenceTask.SequenceSum(16, 15, 3));
        Assert.AreEqual(26, SumOfASequenceTask.SequenceSum(2, 24, 22));
        Assert.AreEqual(2, SumOfASequenceTask.SequenceSum(2, 2, 2));
        Assert.AreEqual(2, SumOfASequenceTask.SequenceSum(2, 2, 1));
        Assert.AreEqual(35, SumOfASequenceTask.SequenceSum(1, 15, 3));
        Assert.AreEqual(0, SumOfASequenceTask.SequenceSum(15, 1, 3));
    }
}