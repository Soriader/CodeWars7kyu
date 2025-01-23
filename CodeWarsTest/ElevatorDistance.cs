using CodeWars7kyu;

namespace CodeWarsTest;

public class ElevatorDistance
{
    [Test]
    public void ElevatorDistanceTest()
    {
        Assert.AreEqual(9, ElevatorDistanceTask.ElevatorDistance(new[] { 5, 2, 8 }));
        Assert.AreEqual(2, ElevatorDistanceTask.ElevatorDistance(new[] { 1, 2, 3 }));
        Assert.AreEqual(18, ElevatorDistanceTask.ElevatorDistance(new[] { 7, 1, 7, 1 }));

    }
}