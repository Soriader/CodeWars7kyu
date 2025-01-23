using CodeWars7kyu;

namespace CodeWarsTest;

public class DisariumNumber
{
    [Test]
    public void DisariumNumberTest()
    {
        Assert.AreEqual("Disarium !!", DisariumNumberTask.DisariumNumber(89));
        Assert.AreEqual("Not !!", DisariumNumberTask.DisariumNumber(564));
        Assert.AreEqual("Disarium !!", DisariumNumberTask.DisariumNumber(135));
        Assert.AreEqual("Not !!", DisariumNumberTask.DisariumNumber(136586));

    }
}