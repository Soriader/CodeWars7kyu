using CodeWars7kyu;

namespace CodeWarsTest;

public class EasyTimeConvert
{
    [Test]
    public void EasyTimeConvertTest()
    {
        Assert.AreEqual("00:00", EasyTimeConvertTask.TimeConvert(0));
        Assert.AreEqual("00:00", EasyTimeConvertTask.TimeConvert(-6));
        Assert.AreEqual("00:08", EasyTimeConvertTask.TimeConvert(8));
        Assert.AreEqual("00:32", EasyTimeConvertTask.TimeConvert(32));
        Assert.AreEqual("02:14", EasyTimeConvertTask.TimeConvert(134));
        Assert.AreEqual("01:03", EasyTimeConvertTask.TimeConvert(63));
        Assert.AreEqual("9429:17", EasyTimeConvertTask.TimeConvert(565757));
    }
}