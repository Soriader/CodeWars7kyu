using CodeWars7kyu;

namespace CodeWarsTest;

public class SortArrays
{
    [Test]
    public void SortArraysTest()
    {
        Assert.AreEqual("one,three,two", string.Join(",", SortArraysTask.SortMe(new[] { "one", "two", "three" })));
    }
}