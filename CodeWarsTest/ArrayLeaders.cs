using CodeWars7kyu;

namespace CodeWarsTest;

public class ArrayLeaders
{
    [Test]
    public void ArrayLeadersTest()
    {
        Assert.AreEqual(new int[] { 4 }, ArrayLeadersTask.ArrayLeaders(new int[] { 1, 2, 3, 4, 0 }));
        Assert.AreEqual(new int[] { 17, 5, 2 }, ArrayLeadersTask.ArrayLeaders(new int[] { 16, 17, 4, 3, 5, 2 }));

    }
}