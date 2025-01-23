using CodeWars7kyu;

namespace CodeWarsTest;

public class MonotoneTravel
{
    [Test]
    public void MonotoneTravelTest()
    {
        Assert.AreEqual(true, MonotoneTravelTask.IsMonotone(new int[] { 1, 2, 3, 3, 4, 5 }));
        Assert.AreEqual(false, MonotoneTravelTask.IsMonotone(Enumerable.Range(1, 5).Reverse().ToArray()));
        Assert.AreEqual(true, MonotoneTravelTask.IsMonotone(new int[] { }));
        Assert.AreEqual(true, MonotoneTravelTask.IsMonotone(new int[] { 5, 5, 5, 5, 5 }));


    }
}