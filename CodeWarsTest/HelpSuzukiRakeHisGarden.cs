using CodeWars7kyu;

namespace CodeWarsTest;

public class HelpSuzukiRakeHisGarden
{
    [Test]
    public void HelpSuzukiRakeHisGardenTest()
    {
        var garden1 = "slug spider rock gravel gravel gravel gravel gravel gravel gravel";
        var expectedGarden1 = "gravel gravel rock gravel gravel gravel gravel gravel gravel gravel";
        Assert.AreEqual(expectedGarden1, HelpSuzukiRakeHisGardenTask.RakeGarden(garden1));

        var garden2 = "gravel gravel gravel gravel gravel gravel gravel gravel gravel rock slug ant gravel gravel snail rock gravel gravel gravel gravel gravel gravel gravel slug gravel ant gravel gravel gravel gravel rock slug gravel gravel gravel gravel gravel snail gravel gravel rock gravel snail slug gravel gravel spider gravel gravel gravel gravel gravel gravel gravel gravel moss gravel gravel gravel snail gravel gravel gravel ant gravel gravel moss gravel gravel gravel gravel snail gravel gravel gravel gravel slug gravel rock gravel gravel rock gravel gravel gravel gravel snail gravel gravel rock gravel gravel gravel gravel gravel spider gravel rock gravel gravel";
        var expectedGarden2 = "gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel rock gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel rock gravel gravel";
        Assert.AreEqual(expectedGarden2, HelpSuzukiRakeHisGardenTask.RakeGarden(garden2));
    }
}