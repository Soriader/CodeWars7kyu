using CodeWars7kyu;

namespace CodeWarsTest;

public class SplitInParts
{
    [Test]
    public void SplitInPartsTest()
    {
        string str = "HelloKata";
        Assert.AreEqual("HelloKata", SplitInPartsTask.SplitInParts(str, 9));

        string str1 = "HelloKata";
        Assert.AreEqual("H e l l o K a t a", SplitInPartsTask.SplitInParts(str1, 1));
    }
}