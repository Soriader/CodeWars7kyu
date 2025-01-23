using CodeWars7kyu;

namespace CodeWarsTest;

public class TheLazyStartupOffice
{
    [Test]
    public void TheLazyStartupOfficeTest()
    {
        var testInput = new string[][] { new[] { "Bob", "Nora" }, new[] { "Ruby", "Carl" } };
        Assert.AreEqual(new[] { "Bob", "Nora", "Carl", "Ruby" }, TheLazyStartupOfficeTask.BinRota(testInput));

        testInput = new string[][] { new[] { "Billy" } };
        Assert.AreEqual(new[] { "Billy" }, TheLazyStartupOfficeTask.BinRota(testInput));

        testInput = new string[][] { new[] { "Billy", "Nancy" } };
        Assert.AreEqual(new[] { "Billy", "Nancy" }, TheLazyStartupOfficeTask.BinRota(testInput));

        testInput = new string[][] { new[] { "Billy" }, new[] { "Megan" }, new[] { "Aki" }, new[] { "Arun" }, new[] { "Joy" } };
        Assert.AreEqual(new[] { "Billy", "Megan", "Aki", "Arun", "Joy" }, TheLazyStartupOfficeTask.BinRota(testInput));

    }
}