using CodeWars7kyu;

namespace CodeWarsTest;

public class CatAndMouse
{
    [Test]
    public void CatAndMouseTest()
    {
        Assert.AreEqual("Escaped!", CatAndMouseTask.CatMouse("C....m"));
        Assert.AreEqual("Caught!", CatAndMouseTask.CatMouse("C..m"));
        Assert.AreEqual("Escaped!", CatAndMouseTask.CatMouse("C.....m"));
    }
}