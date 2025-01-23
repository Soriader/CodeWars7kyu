using CodeWars7kyu;

namespace CodeWarsTest;

public class FindTheCapitals
{
    [Test]
    public void FindTheCapitalsTest()
    {
        Assert.AreEqual(FindTheCapitalsTask.Capitals("CodEWaRs"), new int[] { 0, 3, 4, 6 });
    }
}