using CodeWars7kyu;

namespace CodeWarsTest;

public class FridayThe13thPartOne
{
    [Test]
    public void FridayThe13thPartOneTest()
    {
        Dictionary<string, int> counselors = new Dictionary<string, int>
        {
            {"Mike", 7},
            {"Alysa", 3}
        };
        Assert.AreEqual(new string[] { "Alysa" }, FridayThe13thPartOneTask.KillCount(counselors, 7));
    }
}