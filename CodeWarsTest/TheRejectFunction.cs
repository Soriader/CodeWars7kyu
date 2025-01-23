using CodeWars7kyu;

namespace CodeWarsTest;

public class TheRejectFunction
{
    [Test]
    public void TheRejectFunctionTest()
    {
        Assert.AreEqual(new int[] { 1, 3, 5 }, TheRejectFunctionTask.Reject(new int[] { 1, 2, 3, 4, 5, 6 }, (n) => n % 2 == 0));
    }
}