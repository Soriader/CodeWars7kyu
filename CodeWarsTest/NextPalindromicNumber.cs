using CodeWars7kyu;

namespace CodeWarsTest;

public class NextPalindromicNumber
{
    [Test]
    public void NextPalindromicNumberTest()
    {
        Assert.AreEqual(22, NextPalindromicNumberTask.NextPal(11));
        Assert.AreEqual(191, NextPalindromicNumberTask.NextPal(188));
        Assert.AreEqual(202, NextPalindromicNumberTask.NextPal(191));
        Assert.AreEqual(2552, NextPalindromicNumberTask.NextPal(2541));
    }
}