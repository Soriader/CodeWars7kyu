using CodeWars7kyu;

namespace CodeWarsTest;

public class PowerOfFour
{
    [Test]
    public void PowerOfFourTest()
    {
        Assert.AreEqual(false, PowerOfFourTask.PowerOf4(0));
        Assert.AreEqual(true, PowerOfFourTask.PowerOf4(4));
        Assert.AreEqual(false, PowerOfFourTask.PowerOf4(72));
        Assert.AreEqual(false, PowerOfFourTask.PowerOf4(20));
        Assert.AreEqual(false, PowerOfFourTask.PowerOf4(12));
        Assert.AreEqual(true, PowerOfFourTask.PowerOf4(16));
        Assert.AreEqual(true, PowerOfFourTask.PowerOf4(1));
        Assert.AreEqual(false, PowerOfFourTask.PowerOf4(3.1415));
        Assert.AreEqual(false, PowerOfFourTask.PowerOf4("4"));
        Assert.AreEqual(false, PowerOfFourTask.PowerOf4(null));
    }
}