using CodeWars7kyu;

namespace CodeWarsTest;

public class RotateForAMax
{
    [Test]
    public void RotateForAMaxTest()
    {
        Assert.AreEqual(85821534, RotateForAMaxTask.MaxRot(38458215));
        Assert.AreEqual(988103115, RotateForAMaxTask.MaxRot(195881031));
        Assert.AreEqual(962193428, RotateForAMaxTask.MaxRot(896219342));
        Assert.AreEqual(85821534, RotateForAMaxTask.MaxRot(38458215));
    }
}