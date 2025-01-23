using CodeWars7kyu;

namespace CodeWarsTest;

public class SumOfAngles
{
    [Test]
    public void SumOfAnglesTest()
    {
        Assert.AreEqual(180, SumOfAnglesTask.Angle(3));
        Assert.AreEqual(360, SumOfAnglesTask.Angle(4));
    }
}