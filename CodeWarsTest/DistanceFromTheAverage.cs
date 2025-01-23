using CodeWars7kyu;

namespace CodeWarsTest;

public class DistanceFromTheAverage
{
    [Test]
    public void DistanceFromTheAverageTest()
    {
        Assert.AreEqual(new[] { 4.2, -35.8, -2.8, 23.2, 11.2 }, DistanceFromTheAverageTask.DistancesFromAverage(new[] { 55, 95, 62, 36, 48 }));
        Assert.AreEqual(new[] { 0, 0, 0, 0, 0 }, DistanceFromTheAverageTask.DistancesFromAverage(new[] { 1, 1, 1, 1, 1 }));
        Assert.AreEqual(new[] { -1.0, 1.0, -1.0, 1.0, -1.0, 1.0 }, DistanceFromTheAverageTask.DistancesFromAverage(new[] { 1, -1, 1, -1, 1, -1 }));
        Assert.AreEqual(new[] { -0.8, 1.2, -0.8, 1.2, -0.8 }, DistanceFromTheAverageTask.DistancesFromAverage(new[] { 1, -1, 1, -1, 1 }));
        Assert.AreEqual(new[] { -2.0, 2.0 }, DistanceFromTheAverageTask.DistancesFromAverage(new[] { 2, -2 }));
        Assert.AreEqual(new[] { 0 }, DistanceFromTheAverageTask.DistancesFromAverage(new[] { 1 }));
        Assert.AreEqual(new[] { 6197.6, 6385.6, -26111.4, 6673.6, 6854.6 }, DistanceFromTheAverageTask.DistancesFromAverage(new[] { 123, -65, 32432, -353, -534 }));
    }
}