using CodeWars7kyu;

namespace CodeWarsTest;

public class GreenGlassDoor
{
    [Test]
    public void GreenGlassDoorTest()
    {
        Assert.AreEqual(true, GreenGlassDoorTask.StepThroughWith("moon"));
        Assert.AreEqual(false, GreenGlassDoorTask.StepThroughWith("test"));
        Assert.AreEqual(true, GreenGlassDoorTask.StepThroughWith("glasses"));
        Assert.AreEqual(false, GreenGlassDoorTask.StepThroughWith("airplane"));
        Assert.AreEqual(true, GreenGlassDoorTask.StepThroughWith("free"));
        Assert.AreEqual(false, GreenGlassDoorTask.StepThroughWith("branch"));
        Assert.AreEqual(true, GreenGlassDoorTask.StepThroughWith("aardvark"));
    }
}