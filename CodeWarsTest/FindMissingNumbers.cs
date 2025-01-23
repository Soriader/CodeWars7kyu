using CodeWars7kyu;

namespace CodeWarsTest;

public class FindMissingNumbers
{
    [Test]
    public void FindMissingNumbersTest()
    {
        Assert.AreEqual(new int[] { -1, 0, 2, 3 }, FindMissingNumbersTask.FindMissingNumbers(new int[] { -3, -2, 1, 4 }));
        Assert.AreEqual(new int[0], FindMissingNumbersTask.FindMissingNumbers(new int[] { -1, 0, 1, 2, 3, 4 }));
        Assert.AreEqual(new int[0], FindMissingNumbersTask.FindMissingNumbers(new int[0]));
    }
}