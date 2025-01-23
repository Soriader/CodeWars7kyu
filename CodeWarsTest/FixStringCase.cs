using CodeWars7kyu;

namespace CodeWarsTest;

public class FixStringCase
{
    [Test]
    public void FixStringCaseTest()
    {
        Assert.AreEqual("code", FixStringCaseTask.Solve("code"));
        Assert.AreEqual("CODE", FixStringCaseTask.Solve("CODe"));
        Assert.AreEqual("code", FixStringCaseTask.Solve("COde"));
        Assert.AreEqual("code", FixStringCaseTask.Solve("Code"));

    }
}