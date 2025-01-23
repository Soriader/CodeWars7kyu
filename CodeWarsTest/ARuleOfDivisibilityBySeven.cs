using CodeWars7kyu;

namespace CodeWarsTest;

public class ARuleOfDivisibilityBySeven
{
    [Test]
    public void ARuleOfDivisibilityBySevenTest()
    {
        Assert.AreEqual(new long[] { 10, 2 }, ARuleOfDivisibilityBySevenTask.Seven(1021));
        Assert.AreEqual(new long[] { 7, 2 }, ARuleOfDivisibilityBySevenTask.Seven(1603));
        Assert.AreEqual(new long[] { 35, 1 }, ARuleOfDivisibilityBySevenTask.Seven(371));
        Assert.AreEqual(new long[] { 42, 1 }, ARuleOfDivisibilityBySevenTask.Seven(483));
    }
}