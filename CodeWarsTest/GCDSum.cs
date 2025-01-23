using CodeWars7kyu;

namespace CodeWarsTest;

public class GCDSum
{
    [Test]
    public void GCDSumTest()
    {
        Assert.AreEqual((3, 3), GCDSumTask.Solve(6, 3));
        Assert.AreEqual((2, 6), GCDSumTask.Solve(8, 2));
        Assert.AreEqual((-1, -1), GCDSumTask.Solve(10, 3));
        Assert.AreEqual((4, 8), GCDSumTask.Solve(12, 4));
        Assert.AreEqual((-1, -1), GCDSumTask.Solve(12, 5));
        Assert.AreEqual((10, 40), GCDSumTask.Solve(50, 10));
        Assert.AreEqual((-1, -1), GCDSumTask.Solve(50, 4));
        Assert.AreEqual((5, 5), GCDSumTask.Solve(10, 5));
        Assert.AreEqual((5, 95), GCDSumTask.Solve(100, 5));
        Assert.AreEqual((5, 995), GCDSumTask.Solve(1000, 5));

    }
}