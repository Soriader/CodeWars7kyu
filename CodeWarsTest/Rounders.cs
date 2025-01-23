using CodeWars7kyu;

namespace CodeWarsTest;

public class Rounders
{
    [Test]
    public void RoundersTest()
    {
        var kata = new RoundersTask();

        Assert.AreEqual(20, kata.Rounders(15));

        Assert.AreEqual(1000, kata.Rounders(1234));

        Assert.AreEqual(2000, kata.Rounders(1445));

        Assert.AreEqual(10, kata.Rounders(14));

        Assert.AreEqual(100, kata.Rounders(99));

        Assert.AreEqual(10, kata.Rounders(10));


    }
}