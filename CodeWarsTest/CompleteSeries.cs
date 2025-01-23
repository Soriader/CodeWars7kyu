using CodeWars7kyu;

namespace CodeWarsTest;

public class CompleteSeries
{
    [Test]
    public void CompleteSeriesTest()
    {
        Assert.AreEqual(new int[] { 0, 1 }, CompleteSeriesTask.CompleteSeries(new int[] { 0, 1 }));
        Assert.AreEqual(new int[] { 0, 1, 2, 3, 4, 5, 6 }, CompleteSeriesTask.CompleteSeries(new int[] { 1, 4, 6 }));
        Assert.AreEqual(new int[] { 0, 1, 2, 3, 4, 5 }, CompleteSeriesTask.CompleteSeries(new int[] { 3, 4, 5 }));
        Assert.AreEqual(new int[] { 0, 1, 2 }, CompleteSeriesTask.CompleteSeries(new int[] { 2, 1 }));
        Assert.AreEqual(new int[] { 0 }, CompleteSeriesTask.CompleteSeries(new int[] { 1, 4, 4, 6 }));
    }
}