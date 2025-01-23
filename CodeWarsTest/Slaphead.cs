using CodeWars7kyu;

namespace CodeWarsTest;

public class Slaphead
{
    [Test]
    public void SlapheadTest()
    {
        Assert.AreEqual(new string[] { "----------", "Unicorn!" }, SlapheadTask.Bald("/---------"));
        Assert.AreEqual(new string[] { "--------", "Homer!" }, SlapheadTask.Bald("/-----/-"));
        Assert.AreEqual(new string[] { "---------------", "Careless!" }, SlapheadTask.Bald("--/--/---/-/---"));
    }
}