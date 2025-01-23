using CodeWars7kyu;

namespace CodeWarsTest;

public class ExesAndOhs
{
    [Test]
    public void ExesAndOhsTest()
    {
        Assert.AreEqual(true, ExesAndOhsTask.XO("xo"));
        Assert.AreEqual(true, ExesAndOhsTask.XO("xxOo"));
        Assert.AreEqual(false, ExesAndOhsTask.XO("xxxm"));
        Assert.AreEqual(false, ExesAndOhsTask.XO("Oo"));
        Assert.AreEqual(false, ExesAndOhsTask.XO("ooom"));
    }
}