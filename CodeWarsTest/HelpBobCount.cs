using CodeWars7kyu;

namespace CodeWarsTest;

public class HelpBobCount
{
    [Test]
    public void HelpBobCountTest()
    {
        Assert.AreEqual(7, HelpBobCountTask.CountLettersAndDigits("n!!ice!!123"));
    }
}