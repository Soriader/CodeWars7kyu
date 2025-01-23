using CodeWars7kyu;

namespace CodeWarsTest;

public class DeodorantEvaporator
{
    [Test]
    public void DeodorantEvaporatorTest()
    {
        Assert.AreEqual(22, DeodorantEvaporatorTask.Evaporator(10, 10, 10));
    }
}