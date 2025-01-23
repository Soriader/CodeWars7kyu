using CodeWars7kyu;

namespace CodeWarsTest;

public class ORingArrays
{
    [Test]
    public void ORingArraysTest()
    {
        Assert.AreEqual(new[] { 1, 2, 3 }, ORingArraysTask.OrArrays(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
        Assert.AreEqual(new[] { 5, 7, 7 }, ORingArraysTask.OrArrays(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }));
        Assert.AreEqual(new[] { 1, 2, 3 }, ORingArraysTask.OrArrays(new[] { 1, 2, 3 }, new[] { 1, 2 }));
        Assert.AreEqual(new[] { 1, 2, 3 }, ORingArraysTask.OrArrays(new[] { 1, 2 }, new[] { 1, 2, 3 }));
        Assert.AreEqual(new[] { 1, 2, 3 }, ORingArraysTask.OrArrays(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, 3));
    }
}