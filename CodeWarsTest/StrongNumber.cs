using CodeWars7kyu;

namespace CodeWarsTest;

public class StrongNumber
{
    [Test]
    public void StrongNumberTest()
    {
        Assert.AreEqual("STRONG!!!!", StrongNumberTask.StrongNumber(1));
        Assert.AreEqual("STRONG!!!!", StrongNumberTask.StrongNumber(2));
        Assert.AreEqual("STRONG!!!!", StrongNumberTask.StrongNumber(145));
        Assert.AreEqual("Not Strong !!", StrongNumberTask.StrongNumber(7));
        Assert.AreEqual("Not Strong !!", StrongNumberTask.StrongNumber(93));
        Assert.AreEqual("Not Strong !!", StrongNumberTask.StrongNumber(185));
    }
}