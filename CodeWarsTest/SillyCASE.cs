using CodeWars7kyu;

namespace CodeWarsTest;

public class SillyCASE
{
    [Test]
    public void SillyCASETest()
    {
        Assert.That(SillyCASETask.SillyCase("foobar"), Is.EqualTo("fooBAR"));
        Assert.That(SillyCASETask.SillyCase("codewars"), Is.EqualTo("codeWARS"));
        Assert.That(SillyCASETask.SillyCase("brian"), Is.EqualTo("briAN"));
        Assert.That(SillyCASETask.SillyCase("gvCfEhbvgFUDCCZXHMW"), Is.EqualTo("gvcfehbvgfUDCCZXHMW"));
    }
}