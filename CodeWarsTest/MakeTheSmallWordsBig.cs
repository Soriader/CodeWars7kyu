namespace CodeWarsTest;

using CodeWars7kyu;

public class MakeTheSmallWordsBig
{
    [Test]
    public void MakeTheSmallWordsBigTest()
    {
        Assert.That(MakeTheSmallWordsBigTask.SmallWordHelper("The quick brown fox jumps over the lazy dog"), Is.EqualTo("THE qck brwn FOX jmps vr THE lzy DOG"));
        Assert.That(MakeTheSmallWordsBigTask.SmallWordHelper("I'm just a small word from a small word family"), Is.EqualTo("I'M jst A smll wrd frm A smll wrd fmly"));   
    }
}