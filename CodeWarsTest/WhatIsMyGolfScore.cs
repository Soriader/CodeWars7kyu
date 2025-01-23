using CodeWars7kyu;

namespace CodeWarsTest;

public class WhatIsMyGolfScore
{
    [Test]
    public void WhatIsMyGolfScoreTest()
    {
        Assert.That(WhatIsMyGolfScoreTask.GolfScoreCalculator("453454444344544443", "354445334534445348"), Is.EqualTo(3));
        Assert.That(WhatIsMyGolfScoreTask.GolfScoreCalculator("333333333333333333", "444444444444444444"), Is.EqualTo(18));
    }
}