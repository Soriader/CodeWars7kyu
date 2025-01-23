using CodeWars7kyu;

namespace CodeWarsTest;

public class BinaryAddition
{
    [Test]
    public void BinaryAdditionTest()
    {
        Assert.AreEqual("11", BinaryAdditionTask.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
    }
}