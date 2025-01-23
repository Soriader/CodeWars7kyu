using CodeWars7kyu;

namespace CodeWarsTest;

public class ProgressiveSpiralNumberPosition
{
    [Test]
    public void ProgressiveSpiralNumberPositionTest()
    {
        Assert.AreEqual(1L, ProgressiveSpiralNumberPositionTask.Layers(1));
        Assert.AreEqual(2L, ProgressiveSpiralNumberPositionTask.Layers(5));
        Assert.AreEqual(3L, ProgressiveSpiralNumberPositionTask.Layers(25));
        Assert.AreEqual(4L, ProgressiveSpiralNumberPositionTask.Layers(30));
        Assert.AreEqual(5L, ProgressiveSpiralNumberPositionTask.Layers(50));
    }
}