using CodeWars7kyu;

namespace CodeWarsTest;

public class CaffeineScript
{
    [Test]
    public void CaffeineScriptTest()
    {
        Assert.AreEqual("mocha_missing!", CaffeineScriptTask.CaffeineBuzz(1));
        Assert.AreEqual("Java", CaffeineScriptTask.CaffeineBuzz(3));
        Assert.AreEqual("JavaScript", CaffeineScriptTask.CaffeineBuzz(6));
        Assert.AreEqual("CoffeeScript", CaffeineScriptTask.CaffeineBuzz(12));
    }
}