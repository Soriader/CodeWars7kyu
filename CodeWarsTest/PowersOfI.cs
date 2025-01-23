using CodeWars7kyu;

namespace CodeWarsTest;

public class PowersOfI
{
    [Test]
    public void PowersOfITest()
    {
        int i = 4;
        Assert.AreEqual("1", PowersOfITask.Pofi(0));
        Assert.AreEqual("i", PowersOfITask.Pofi(1));
        Assert.AreEqual("-1", PowersOfITask.Pofi(2));
        Assert.AreEqual("-i", PowersOfITask.Pofi(3));
        Assert.AreEqual("1", PowersOfITask.Pofi(i));
        Assert.AreEqual("i", PowersOfITask.Pofi(i + 1));
        Assert.AreEqual("-1", PowersOfITask.Pofi(i + 2));
        Assert.AreEqual("-i", PowersOfITask.Pofi(i + 3));
        i += 4;
        Assert.AreEqual("1", PowersOfITask.Pofi(i));
        Assert.AreEqual("i", PowersOfITask.Pofi(i + 1));
        Assert.AreEqual("-1", PowersOfITask.Pofi(i + 2));
        Assert.AreEqual("-i", PowersOfITask.Pofi(i + 3));
    }
}