using CodeWars7kyu;

namespace CodeWarsTest;

public class PointInAUnitCircle
{
    [Test]
    public void PointInAUnitCircleTest()
    {
        Assert.AreEqual(true, PointInAUnitCircleTask.PointInCircle(0, 0));
        Assert.AreEqual(false, PointInAUnitCircleTask.PointInCircle(2, 0));
        Assert.AreEqual(true, PointInAUnitCircleTask.PointInCircle(0, 0.9));
        Assert.AreEqual(true, PointInAUnitCircleTask.PointInCircle(0.5, 0.5));
        Assert.AreEqual(false, PointInAUnitCircleTask.PointInCircle(1, 0));
    }
}