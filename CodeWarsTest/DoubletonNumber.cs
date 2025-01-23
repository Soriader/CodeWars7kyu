using CodeWars7kyu;

namespace CodeWarsTest;

public class DoubletonNumber
{
    [Test]
    public void DoubletonNumberTest()
    {
        Assert.AreEqual(121, DoubletonNumberTask.Doubleton(120));
        Assert.AreEqual(1311, DoubletonNumberTask.Doubleton(1234));
        Assert.AreEqual(12, DoubletonNumberTask.Doubleton(10));

    }
}