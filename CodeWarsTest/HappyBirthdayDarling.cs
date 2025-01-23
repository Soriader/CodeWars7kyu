using CodeWars7kyu;

namespace CodeWarsTest;

public class HappyBirthdayDarling
{
    [Test]
    public void HappyBirthdayDarlingTest()
    {
        Assert.AreEqual("32? That's just 20, in base 16!", HappyBirthdayDarlingTask.WomensAge(32));
        Assert.AreEqual("39? That's just 21, in base 19!", HappyBirthdayDarlingTask.WomensAge(39));
        Assert.AreEqual("22? That's just 20, in base 11!", HappyBirthdayDarlingTask.WomensAge(22));
        Assert.AreEqual("65? That's just 21, in base 32!", HappyBirthdayDarlingTask.WomensAge(65));
        Assert.AreEqual("83? That's just 21, in base 41!", HappyBirthdayDarlingTask.WomensAge(83));
    }
}