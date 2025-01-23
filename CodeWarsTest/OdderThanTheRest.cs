using CodeWars7kyu;

namespace CodeWarsTest;

public class OdderThanTheRest
{
    [Test]
    public void OdderThanTheRestTest()
    {
        Assert.AreEqual(3, OdderThanTheRestTask.OddOne(new List<int> { 2, 4, 6, 7, 10 }));
        Assert.AreEqual(4, OdderThanTheRestTask.OddOne(new List<int> { 2, 16, 98, 10, 13, 78 }));
        Assert.AreEqual(4, OdderThanTheRestTask.OddOne(new List<int> { 4, -8, 98, -12, -7, 90, 100 }));
        Assert.AreEqual(-1, OdderThanTheRestTask.OddOne(new List<int> { 2, 4, 6, 8 }));
    }
}