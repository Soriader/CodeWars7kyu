using CodeWars7kyu;

namespace CodeWarsTest;

public class ChangingLetters
{
    [Test]
    public void ChangingLettersTest()
    {
        Assert.AreEqual("HEllOWOrld!", ChangingLettersTask.Swap("HelloWorld!"));
        Assert.AreEqual("SUndAy", ChangingLettersTask.Swap("Sunday"));


    }
}