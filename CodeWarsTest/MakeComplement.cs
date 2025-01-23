using CodeWars7kyu;

namespace CodeWarsTest;

public class MakeComplement
{
    [Test]
    public void MakeComplementTest()
    {
        Assert.That(MakeComplementTask.MakeComplement("ATGC"), Is.EqualTo("TACG"));
        Assert.That(MakeComplementTask.MakeComplement("AAGG"), Is.EqualTo("TTCC"));
        Assert.That(MakeComplementTask.MakeComplement("ATTGC"), Is.EqualTo("TAACG"));
    }
}