using CodeWars7kyu;

namespace CodeWarsTest;

public class ConsecutiveLetters
{
    [Test]
    public void ConsecutiveLettersTest()
    {
        Assert.AreEqual(true, ConsecutiveLettersTask.Solve("abc"));
        Assert.AreEqual(false, ConsecutiveLettersTask.Solve("abd"));
        Assert.AreEqual(true, ConsecutiveLettersTask.Solve("dabc"));
        Assert.AreEqual(false, ConsecutiveLettersTask.Solve("abbc"));
    }
}