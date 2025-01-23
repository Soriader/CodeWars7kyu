using CodeWars7kyu;

namespace CodeWarsTest;

public class OverTheRoad
{
    [Test]
    public void OverTheRoadTest()
    {
        Assert.AreEqual(6, OverTheRoadTask.OverTheRoad(1, 3));
        Assert.AreEqual(4, OverTheRoadTask.OverTheRoad(3, 3));
        Assert.AreEqual(5, OverTheRoadTask.OverTheRoad(2, 3));
        Assert.AreEqual(8, OverTheRoadTask.OverTheRoad(3, 5));
        Assert.AreEqual(16, OverTheRoadTask.OverTheRoad(7, 11));
    }
}