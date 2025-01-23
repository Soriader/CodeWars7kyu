using CodeWars7kyu;

namespace CodeWarsTest;

public class CountAllTheSheepOnFarm
{
    [Test]
    public void CountAllTheSheepOnFarmTest()
    {
        CountAllTheSheepOnFarmTask kata = new CountAllTheSheepOnFarmTask();
        int[] friday = new int[] { 5, 1, 4 };
        int[] saturday = new int[] { 5, 4 };
        Assert.AreEqual(10, kata.lostSheep(friday, saturday, 29));
    }
}