using CodeWars7kyu;

namespace CodeWarsTest;

public class FusionChamberShutdown
{
    [Test]
    public void FusionChamberShutdownTest()
    {
        Assert.AreEqual((5, 45, 0), FusionChamberShutdownTask.Burner(45, 11, 100));
        Assert.AreEqual((0, 0, 354), FusionChamberShutdownTask.Burner(354, 1023230, 0));
        Assert.AreEqual((1, 346, 0), FusionChamberShutdownTask.Burner(939, 3, 694));
        Assert.AreEqual((20, 215, 0), FusionChamberShutdownTask.Burner(215, 41, 82100));
        Assert.AreEqual((0, 26, 0), FusionChamberShutdownTask.Burner(113, 0, 52));
    }
}