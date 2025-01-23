using CodeWars7kyu;

namespace CodeWarsTest;

public class SushiGoRound
{
    [Test]
    public void SushiGoRoundTest()
    {
        Assert.AreEqual(4, SushiGoRoundTask.TotalBill("rr"));
        Assert.AreEqual(8, SushiGoRoundTask.TotalBill("rr rrr"));
        Assert.AreEqual(16, SushiGoRoundTask.TotalBill("rr rrr rrr rr"));
        Assert.AreEqual(34, SushiGoRoundTask.TotalBill("rrrrrrrrrrrrrrrrrr   rr r"));
        Assert.AreEqual(0, SushiGoRoundTask.TotalBill(""));
    }
}