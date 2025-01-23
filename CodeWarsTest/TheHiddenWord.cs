using CodeWars7kyu;

namespace CodeWarsTest;

public class TheHiddenWord
{
    [Test]
    public void TheHiddenWordTest()
    {
        TheHiddenWordTask kata = new TheHiddenWordTask();
        Assert.That(kata.Hidden(942547), Is.EqualTo("melted"));
    }
}