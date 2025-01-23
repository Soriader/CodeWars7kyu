using CodeWars7kyu;

namespace CodeWarsTest;

public class SimpleStringMatching
{
    [Test]
    public void SimpleStringMatchingTest()
    {
        Assert.AreEqual(true, SimpleStringMatchingTask.Solve("code*s", "codewars"));
        Assert.AreEqual(true, SimpleStringMatchingTask.Solve("codewar*s", "codewars"));
        Assert.AreEqual(true, SimpleStringMatchingTask.Solve("*c", "c"));
        Assert.AreEqual(true, SimpleStringMatchingTask.Solve("*", "asterisk"));
        Assert.AreEqual(false, SimpleStringMatchingTask.Solve("d*oll", "dual"));
        Assert.AreEqual(false, SimpleStringMatchingTask.Solve("*osd", "asterisk"));
        Assert.AreEqual(false, SimpleStringMatchingTask.Solve("*ea", "bean"));
    }
}