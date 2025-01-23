using CodeWars7kyu;

namespace CodeWarsTest;

public class FindTheLuckyNumbers
{
    [Test]
    public void FindTheLuckyNumbersTest()
    {
        Assert.AreEqual(new int[] { 7, 70, 17 }, FindTheLuckyNumbersTask.FilterLucky(new int[] { 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }));
        Assert.AreEqual(new int[] { }, FindTheLuckyNumbersTask.FilterLucky(new int[] { }));
    }
}