using CodeWars7kyu;

namespace CodeWarsTest;

public class NiceArray
{
    [Test]
    public void NiceArrayTest()
    {
        Assert.AreEqual(true, NiceArrayTask.IsNice(new int[] { 2, 10, 9, 3 }));
        Assert.AreEqual(false, NiceArrayTask.IsNice(new int[] { 3, 4, 5, 7 }));
    }
}