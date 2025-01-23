using CodeWars7kyu;

namespace CodeWarsTest;

public class MobileDisplayKeystrokes
{
    [Test]
    public void MobileDisplayKeystrokesTest()
    {
        Assert.AreEqual(0, MobileDisplayKeystrokesTask.MobileKeyboard(""));
        Assert.AreEqual(2, MobileDisplayKeystrokesTask.MobileKeyboard("*#"));
        Assert.AreEqual(3, MobileDisplayKeystrokesTask.MobileKeyboard("123"));
        Assert.AreEqual(26, MobileDisplayKeystrokesTask.MobileKeyboard("codewars"));
        Assert.AreEqual(16, MobileDisplayKeystrokesTask.MobileKeyboard("zruf"));
        Assert.AreEqual(37, MobileDisplayKeystrokesTask.MobileKeyboard("thisisasms"));
        Assert.AreEqual(107, MobileDisplayKeystrokesTask.MobileKeyboard("longwordwhichdontreallymakessense"));
        Assert.AreEqual(94, MobileDisplayKeystrokesTask.MobileKeyboard("1234567890*#abcdefghijklmnopqrstuvwxyz"));
    }
}