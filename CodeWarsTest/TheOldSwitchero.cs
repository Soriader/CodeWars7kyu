using CodeWars7kyu;

namespace CodeWarsTest;

public class TheOldSwitchero
{
    [Test]
    public void TheOldSwitcheroTest()
    {
        Assert.AreEqual("th3s 6s my str15ng", TheOldSwitcheroTask.Vowel2Index("this is my string"));
        Assert.AreEqual("C2d4w6rs 10s th15 b18st s23t25 27n th32 w35rld", TheOldSwitcheroTask.Vowel2Index("Codewars is the best site in the world"));
        Assert.AreEqual("T2m4rr7w 10s g1415ng t20 b23 r2627n29ng", TheOldSwitcheroTask.Vowel2Index("Tomorrow is going to be raining"));
    }
}