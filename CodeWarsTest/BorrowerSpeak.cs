using CodeWars7kyu;

namespace CodeWarsTest;

public class BorrowerSpeak
{
    [Test]
    public void BorrowerSpeakTest()
    {
        Assert.AreEqual("whatfickdamncake", BorrowerSpeakTask.Borrow("WhAt! FiCK! DaMn CAke?"));
        Assert.AreEqual("thebigpeoplehere", BorrowerSpeakTask.Borrow("THE big PeOpLE Here!!"));
        Assert.AreEqual("iamatinyboy", BorrowerSpeakTask.Borrow("i AM a TINY BoY!!"));
    }
}