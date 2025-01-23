using CodeWars7kyu;

namespace CodeWarsTest;

public class CountConsonants
{
    [Test]
    public void CountConsonantsTest()
    {
        Assert.AreEqual(0, CountConsonantsTask.ConsonantCount(""));
        Assert.AreEqual(0, CountConsonantsTask.ConsonantCount("aaaaa"));
        Assert.AreEqual(7, CountConsonantsTask.ConsonantCount("helLo world"));
        Assert.AreEqual(0, CountConsonantsTask.ConsonantCount("012456789"));
        Assert.AreEqual(2, CountConsonantsTask.ConsonantCount("012345_Cb"));
    }
}