using CodeWars7kyu;

namespace CodeWarsTest;

public class IsItALetter
{
    [Test]
    public void IsItALetterTest()
    {
        Assert.AreEqual(true, IsItALetterTask.IsItLetter('a'));
        Assert.AreEqual(false, IsItALetterTask.IsItLetter('1'));
    }
}