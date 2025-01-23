using CodeWars7kyu;

namespace CodeWarsTest;

public class StantonMeasure
{
    [Test]
    public void StantonMeasureTest()
    {
        Assert.AreEqual(3, StantonMeasureTask.StantonMeasure(new int[] { 1, 4, 3, 2, 1, 2, 3, 2 }));
    }
}