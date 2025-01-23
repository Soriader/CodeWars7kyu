using CodeWars7kyu;

namespace CodeWarsTest;

public class GrowthOfAPopulation
{
    [Test]
    public static void GrowthOfAPopulationTest()
    {
        Assert.AreEqual(15, GrowthOfAPopulationTask.NbYear(1500, 5, 100, 5000));
        Assert.AreEqual(10, GrowthOfAPopulationTask.NbYear(1500000, 2.5, 10000, 2000000));
        Assert.AreEqual(94, GrowthOfAPopulationTask.NbYear(1500000, 0.25, 1000, 2000000));
    }
}