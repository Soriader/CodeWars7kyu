using CodeWars7kyu;

namespace CodeWarsTest;

public class MinimizeSumOfArray
{
    [Test]
    public void MinimizeSumOfArrayTest()
    {
        Assert.AreEqual(342, MinimizeSumOfArrayTask.MinSum(new int[] { 12, 6, 10, 26, 3, 24 }));
        Assert.AreEqual(74, MinimizeSumOfArrayTask.MinSum(new int[] { 9, 2, 8, 7, 5, 4, 0, 6 }));

    }
}