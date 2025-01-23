using CodeWars7kyu;

namespace CodeWarsTest;

public class ReverseFactorials
{
    [Test]
    public void ReverseFactorialsTest()
    {
        Assert.AreEqual("5!", ReverseFactorialsTask.ReverseFactorial(120));
    }
}