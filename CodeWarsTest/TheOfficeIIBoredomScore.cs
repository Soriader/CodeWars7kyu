using CodeWars7kyu;

namespace CodeWarsTest;

public class TheOfficeIIBoredomScore
{
    [Test]
    public void TheOfficeIIBoredomScoreTest()
    {
        Assert.AreEqual("kill me now", TheOfficeIIBoredomScoreTask.Boredom(new Dictionary<string, string>() { { "Tim", "accounts" }, { "Jim", "trading" }, { "Sandy", "regulation" }, { "Andy", "accounts" }, { "Katie", "finance" }, { "Laura", "IS" } }));
        Assert.AreEqual("i can handle this", TheOfficeIIBoredomScoreTask.Boredom(new Dictionary<string, string>() { { "Jim", "pissing about" }, { "Tim", "regulation" }, { "Andy", "IS" }, { "Laura", "pissing about" }, { "Alex", "canteen" }, { "John", "canteen" } }));
        Assert.AreEqual("party time!!", TheOfficeIIBoredomScoreTask.Boredom(new Dictionary<string, string>() { { "Andy", "pissing about" }, { "Tim", "accounts" }, { "Smith", "pissing about" }, { "Randy", "pissing about" }, { "Sandy", "IS" }, { "Laura", "pissing about" } }));
    }
}