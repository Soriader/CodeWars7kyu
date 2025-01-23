using CodeWars7kyu;

namespace CodeWarsTest;

public class InsertDashes
{
    [Test]
    public void InsertDashesTest()
    {
        Assert.AreEqual("4547-9-3", InsertDashesTask.InsertDash(454793));
        Assert.AreEqual("123456", InsertDashesTask.InsertDash(123456));
        Assert.AreEqual("1003-567", InsertDashesTask.InsertDash(1003567));
    }
}