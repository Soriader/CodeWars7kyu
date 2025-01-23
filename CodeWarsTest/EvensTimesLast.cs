using CodeWars7kyu;

namespace CodeWarsTest;

public class EvensTimesLast
{
    [Test]
    public void EvensTimesLastTest()
    {
        Assert.AreEqual(30, EvensTimesLastTask.EvenTimesLast(new int[] { 2, 3, 4, 5 }));
        Assert.AreEqual(0, EvensTimesLastTask.EvenTimesLast(new int[] { 2, 3, 4, 5, 0 }));
        Assert.AreEqual(-6, EvensTimesLastTask.EvenTimesLast(new int[] { 2, 3, 4, -1 }));
        Assert.AreEqual(91, EvensTimesLastTask.EvenTimesLast(new[] { 7, 13 }));
        Assert.AreEqual(49, EvensTimesLastTask.EvenTimesLast(new[] { 7 }));


    }
}