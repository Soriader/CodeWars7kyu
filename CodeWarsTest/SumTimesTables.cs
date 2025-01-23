using CodeWars7kyu;

namespace CodeWarsTest;

public class SumTimesTables
{
    [Test]
    public void SumTimesTablesTest()
    {
        Assert.AreEqual(30, SumTimesTablesTask.SumTimesTable(new List<int> { 2, 3 }, 1, 3));
        Assert.AreEqual(9, SumTimesTablesTask.SumTimesTable(new List<int> { 1, 3, 5 }, 1, 1));
        Assert.AreEqual(495, SumTimesTablesTask.SumTimesTable(new List<int> { 1, 3, 5 }, 1, 10));
    }
}