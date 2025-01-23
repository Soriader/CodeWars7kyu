using CodeWars7kyu;

namespace CodeWarsTest;

public class OperationsWithSequence
{
    [Test]
    public void OperationsWithSequenceTest()
    {
        Assert.AreEqual(31, OperationsWithSequenceTask.Calc(new[] { 0, 2, 1, -6, -3, 3 }));
    }
}