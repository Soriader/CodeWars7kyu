using CodeWars7kyu;

namespace CodeWarsTest;

public class AlternateCase
{
    [Test]
    public void AlternateCaseTest()
    {
        Assert.AreEqual("ABC", AlternateCaseTask.AlternateCase("abc"));
        Assert.AreEqual("abc", AlternateCaseTask.AlternateCase("ABC"));
        Assert.AreEqual("hELLO wORLD", AlternateCaseTask.AlternateCase("Hello World"));
    }
}