using CodeWars7kyu;

namespace CodeWarsTest;

public class ThePonyExpress
{
    [Test]
    public void ThePonyExpressTest()
    {
        Assert.AreEqual(1, ThePonyExpressTask.Riders(new int[] { 18, 15 }));
        Assert.AreEqual(2, ThePonyExpressTask.Riders(new int[] { 43, 23, 40, 13 }));
        Assert.AreEqual(3, ThePonyExpressTask.Riders(new int[] { 33, 8, 16, 47, 30, 30, 46 }));
        Assert.AreEqual(4, ThePonyExpressTask.Riders(new int[] { 6, 24, 6, 8, 28, 8, 23, 47, 17, 29, 37, 18, 40, 49 }));
    }
}