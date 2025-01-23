using CodeWars7kyu;

namespace CodeWarsTest;

public class LastDigitsOfANumber
{
    [Test]
    public void LastDigitsOfANumberTest()
    {
        Assert.AreEqual(new[] { 1 }, lastDigitsOfANumberTask.LastDigit(1, 1));
        Assert.AreEqual(new[] { 3, 7, 6, 7 }, lastDigitsOfANumberTask.LastDigit(123767, 4));
        Assert.AreEqual(new[] { 0 }, lastDigitsOfANumberTask.LastDigit(0, 1));
        Assert.AreEqual(new[] { 5, 6, 4, 7, 8, 6, 7, 5, 8, 5 }, lastDigitsOfANumberTask.LastDigit(34625647867585, 10));
        Assert.AreEqual(new int[] { }, lastDigitsOfANumberTask.LastDigit(1234, 0));
        Assert.AreEqual(new int[] { }, lastDigitsOfANumberTask.LastDigit(24134, -4));
        Assert.AreEqual(new[] { 1, 3, 4, 3 }, lastDigitsOfANumberTask.LastDigit(1343, 5));
    }
}