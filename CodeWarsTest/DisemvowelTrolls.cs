using CodeWars7kyu;

namespace CodeWarsTest;

public class DisemvowelTrolls
{
    [Test]
    public void DisemvowelTrollsTest()
    {
        Assert.AreEqual("Ths wbst s fr lsrs LL!", DisemvowelTrollsTask.Disemvowel("This website is for losers LOL!"));
        Assert.AreEqual("Wht r y,  cmmnst?", DisemvowelTrollsTask.Disemvowel("What are you, a communist?"));
        Assert.AreEqual("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd", DisemvowelTrollsTask.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
    }
}