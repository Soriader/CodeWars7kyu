using CodeWars7kyu;

namespace CodeWarsTest;

public class MaxDiffEasy
{
    [Test]
    public void MaxDiffEasyTest()
    {
        Assert.AreEqual(6, MaxDiffEasyTask.MaxDiff(new[] { 0, 1, 2, 3, 4, 5, 6 }));
        Assert.AreEqual(11, MaxDiffEasyTask.MaxDiff(new[] { -0, 1, 2, -3, 4, 5, -6 }));
        Assert.AreEqual(16, MaxDiffEasyTask.MaxDiff(new[] { 0, 1, 2, 3, 4, 5, 16 }));
        Assert.AreEqual(0, MaxDiffEasyTask.MaxDiff(new[] { 16 }));
        Assert.AreEqual(0, MaxDiffEasyTask.MaxDiff(new int[] { }));
    }
}