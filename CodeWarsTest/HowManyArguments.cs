using CodeWars7kyu;

namespace CodeWarsTest;

public class HowManyArguments
{
    [Test]
    public void HowManyArgumentsTest()
    {
        Assert.AreEqual(3, HowManyArgumentsTask.CountArgs(1, 2, 3));
        Assert.AreEqual(3, HowManyArgumentsTask.CountArgs(1, 2, "uhsaf uas"));
        Assert.AreEqual(1, HowManyArgumentsTask.CountArgs(1));
        Assert.AreEqual(4, HowManyArgumentsTask.CountArgs('a', 865, "asfhgajsf", new object[] { "dawdjio", null, new List<object>() }));
        Assert.AreEqual(0, HowManyArgumentsTask.CountArgs());
    }
}