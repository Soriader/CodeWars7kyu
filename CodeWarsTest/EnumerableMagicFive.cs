using CodeWars7kyu;

namespace CodeWarsTest;

public class EnumerableMagicFive
{
    [Test]
    public void EnumerableMagicFiveTest()
    {
        Assert.AreEqual(true, EnumerableMagicFiveTask.One(new int[] { 1, 2, 3, 4, 5 }, v => v < 2));
        Assert.AreEqual(false, EnumerableMagicFiveTask.One(new int[] { 1, 2, 3, 4, 5 }, v => v % 2 != 0));
        Assert.AreEqual(false, EnumerableMagicFiveTask.One(new int[] { 1, 2, 3, 4, 5 }, v => v > 5));
    }
}