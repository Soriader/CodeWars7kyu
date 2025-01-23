using CodeWars7kyu;

namespace CodeWarsTest;

public class FindTheStrayNumber
{
    [Test]
    public void FindTheStrayNumberTest()
    {
        Assert.AreEqual(2, FindTheStrayNumberTask.Stray(new int[] { 1, 1, 2 }));
    }
}