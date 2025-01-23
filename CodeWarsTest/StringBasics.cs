using CodeWars7kyu;

namespace CodeWarsTest;

public class StringBasics
{
    [Test]
    public void StringBasicsTest()
    {
        Assert.AreEqual(new string[] { "12345" }, StringBasicsTask.GetUserIds("uid12345"));
        Assert.AreEqual(new string[] { "abc" }, StringBasicsTask.GetUserIds("   uidabc  "));
        Assert.AreEqual(new string[] { "swagger" }, StringBasicsTask.GetUserIds("#uidswagger"));
        Assert.AreEqual(new string[] { "one", "two" }, StringBasicsTask.GetUserIds("uidone, uidtwo"));
        Assert.AreEqual(new string[] { "capslock" }, StringBasicsTask.GetUserIds("uidCAPSLOCK"));
    }
}