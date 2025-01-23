using CodeWars7kyu;

namespace CodeWarsTest;

public class TrimmingAString
{
    [Test]
    public void TrimmingAStringTest()
    {
        Assert.AreEqual("Creating ka...", TrimmingAStringTask.TrimString("Creating kata is fun", 14));
        Assert.AreEqual("H...", TrimmingAStringTask.TrimString("He", 1));
        Assert.AreEqual("He...", TrimmingAStringTask.TrimString("Hey", 2));
        Assert.AreEqual("Hey", TrimmingAStringTask.TrimString("Hey", 3));
        Assert.AreEqual("Cr...", TrimmingAStringTask.TrimString("Creating kata is fun", 2));
        Assert.AreEqual("Cod...", TrimmingAStringTask.TrimString("Code Wars is pretty rad", 3));
        Assert.AreEqual("Coding rocks", TrimmingAStringTask.TrimString("Coding rocks", 12));
        Assert.AreEqual("Code Wars is pretty rad", TrimmingAStringTask.TrimString("Code Wars is pretty rad", 50));
        Assert.AreEqual("London is freezing", TrimmingAStringTask.TrimString("London is freezing", 18));
    }
}