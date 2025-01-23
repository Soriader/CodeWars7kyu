using CodeWars7kyu;

namespace CodeWarsTest;

public class indTheNthDigitOfANumber
{
    [Test]
    public void FindTheNthDigitOfANumberTest()
    {
        Assert.AreEqual(5, FindTheNthDigitOfANumberTask.FindDigit(5673, 4));
        Assert.AreEqual(2, FindTheNthDigitOfANumberTask.FindDigit(129, 2));
        Assert.AreEqual(8, FindTheNthDigitOfANumberTask.FindDigit(-2825, 3));
        Assert.AreEqual(0, FindTheNthDigitOfANumberTask.FindDigit(-456, 4));
        Assert.AreEqual(0, FindTheNthDigitOfANumberTask.FindDigit(0, 20));
        Assert.AreEqual(-1, FindTheNthDigitOfANumberTask.FindDigit(65, 0));
        Assert.AreEqual(-1, FindTheNthDigitOfANumberTask.FindDigit(24, -8));
    }
}