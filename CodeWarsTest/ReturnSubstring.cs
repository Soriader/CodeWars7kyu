using CodeWars7kyu;

namespace CodeWarsTest;

public class ReturnSubstring
{
    [Test]
    public void ReturnSubstringTest() 
    {
        Assert.AreEqual(2, ReturnSubstringTask.SubstringCount("abcdeb", "b"));
        Assert.AreEqual(1, ReturnSubstringTask.SubstringCount("abcdeb", "a"));
        Assert.AreEqual(3, ReturnSubstringTask.SubstringCount("ccddeeccddeecc", "cc"));

    }
}