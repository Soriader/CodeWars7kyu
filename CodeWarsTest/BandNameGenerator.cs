using CodeWars7kyu;

namespace CodeWarsTest;

public class BandNameGenerator
{
    [Test]
    public void BandNameGeneratorTest()
    {
        Assert.AreEqual("The Knife", BandNameGeneratorTask.BandNameGenerator("knife"));
        Assert.AreEqual("Tartart", BandNameGeneratorTask.BandNameGenerator("tart"));
        Assert.AreEqual("Sandlesandles", BandNameGeneratorTask.BandNameGenerator("sandles"));
        Assert.AreEqual("The Bed", BandNameGeneratorTask.BandNameGenerator("bed"));
    }
}