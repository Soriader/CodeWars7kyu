using CodeWars7kyu;

namespace CodeWarsTest;

public class ZipIt
{
    [Test]
    public void ZipItTest()
    {
        Assert.AreEqual(new object[] { "1a", "2b", "3c", "4d", "5e" }, ZipItTask.ZipIt(new object[] { 1, 2, 3, 4, 5 }, new object[] { 'a', 'b', 'c', 'd', 'e' }, (c, d) => c + "" + d));

    }
}