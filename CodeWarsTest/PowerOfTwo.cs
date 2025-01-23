using CodeWars7kyu;

namespace CodeWarsTest;

public class PowerOfTwo
{
    [Test]
    public void PowerOfTwoTest()
    {
        Assert.AreEqual(true, PowerOfTwoTask.PowerOfTwo(4096));
        Assert.AreEqual(true, PowerOfTwoTask.PowerOfTwo(2));
        Assert.AreEqual(false, PowerOfTwoTask.PowerOfTwo(9));

    }
}