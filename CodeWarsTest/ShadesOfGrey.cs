using CodeWars7kyu;

namespace CodeWarsTest;

public class ShadesOfGrey
{
    [Test]
    public void ShadesOfGreyTest()
    {
        Assert.AreEqual(254, ShadesOfGreyTask.ShadesOfGrey(255).Length);
        CollectionAssert.AreEquivalent(new[] { "#010101", "#020202", "#030303", "#040404", "#050505","#060606", "#070707", "#080808", "#090909", "#0a0a0a"},ShadesOfGreyTask.ShadesOfGrey(10));
    }
}