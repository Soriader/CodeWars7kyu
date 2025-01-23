using CodeWars7kyu;

namespace CodeWarsTest;

public class RowWeights
{
    [Test]
    public void RowWeightsTest()
    {
        Assert.AreEqual(new int[] {0,0}, RowWeightsTask.RowWeights(new int[] {0}));
        Assert.AreEqual(new int[] { 0, 1 }, RowWeightsTask.RowWeights(new int[] {0, 1, 0}));
        Assert.AreEqual(new int[] { 62, 27 }, RowWeightsTask.RowWeights(new int[] { 13, 27,49 }));
        Assert.AreEqual(new int[] { 150, 151 }, RowWeightsTask.RowWeights(new int[] { 100, 51, 50, 100 }));
    }
}