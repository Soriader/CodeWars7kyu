using CodeWars7kyu;

namespace CodeWarsTest;

public class ZeroBalancedArray
{
    [Test]
    public void ZeroBalancedArrayTest()
    {
        Assert.AreEqual(false, ZeroBalancedArrayTask.IsZeroBalanced(new List<int> { 3 }));
        Assert.AreEqual(true, ZeroBalancedArrayTask.IsZeroBalanced(new List<int> { 0, 0, 0, 0, 0, 0 }));
    }
}