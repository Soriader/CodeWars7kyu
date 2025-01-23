using CodeWars7kyu;

namespace CodeWarsTest;

public class HarvestFestival
{
    [Test]
    public void HarvestFestivalTest()
    {
        Assert.AreEqual("----@@@----@@@----@@@----@@@", HarvestFestivalTask.Plant('@', 4, 3, 23));
        Assert.AreEqual("-~~~~~~", HarvestFestivalTask.Plant('~', 1, 6, 30));
        Assert.AreEqual("----------------------------------------------------------------------------------------------------#", HarvestFestivalTask.Plant('#', 10, 2, 15));
        Assert.AreEqual("----*", HarvestFestivalTask.Plant('*', 2, 4, 8));
        Assert.AreEqual("--<<--<<", HarvestFestivalTask.Plant('<', 2, 2, 28));
    }
}