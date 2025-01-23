using CodeWars7kyu;

namespace CodeWarsTest;

public class RemoveAnchorFromURL
{
    [Test]
    public void RemoveAnchorFromURLTest()
    {
        Assert.AreEqual("www.codewars.com", RemoveAnchorFromURLTask.RemoveUrlAnchor("www.codewars.com#about"));
        Assert.AreEqual("www.codewars.com/katas/?page=1", RemoveAnchorFromURLTask.RemoveUrlAnchor("www.codewars.com/katas/?page=1#about"));
        Assert.AreEqual("www.codewars.com/katas/", RemoveAnchorFromURLTask.RemoveUrlAnchor("www.codewars.com/katas/"));
    }
}