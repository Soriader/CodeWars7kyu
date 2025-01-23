using CodeWars7kyu;

namespace CodeWarsTest;

public class BuildingBlocks
{
    [Test]
    public void BuildingBlocksTest()
    {
        BuildingBlocksTask b = new BuildingBlocksTask(new int[] { 2, 2, 2 });
        Assert.AreEqual(2, b.GetWidth());
        Assert.AreEqual(2, b.GetLength());
        Assert.AreEqual(2, b.GetHeight());
        Assert.AreEqual(8, b.GetVolume());
        Assert.AreEqual(24, b.GetSurfaceArea());
    }
}