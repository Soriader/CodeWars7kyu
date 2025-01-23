using CodeWars7kyu;

namespace CodeWarsTest;

public class SortTheGiftCode
{
    [Test]
    public void SortTheGiftCodeTest()
    {
        Assert.AreEqual("abcdef", SortTheGiftCodeTask.SortGiftCode("abcdef"));
        Assert.AreEqual("kpqsuvy", SortTheGiftCodeTask.SortGiftCode("pqksuvy"));
        Assert.AreEqual("abcdefghijklmnopqrstuvwxyz", SortTheGiftCodeTask.SortGiftCode("zyxwvutsrqponmlkjihgfedcba"));
    }
}