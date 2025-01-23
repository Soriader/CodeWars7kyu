using CodeWars7kyu;

namespace CodeWarsTest;

public class nscrambledEggs
{
    [Test]
    public void UnscrambledEggsTest()
    {
        Assert.AreEqual("code here", UnscrambledEggsTask.UnscrambleEggs("ceggodegge heggeregge"));
        Assert.AreEqual("FUN KATA", UnscrambledEggsTask.UnscrambleEggs("FeggUNegg KeggATeggA"));
    }
}