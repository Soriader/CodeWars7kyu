using CodeWars7kyu;

namespace CodeWarsTest;

public class StringEndsWith
{
    [Test]
    public void StringEndsWithTest()
    {
        Assert.AreEqual(true, StringEndsWithTask.Solution("samurai", "ai"));
        Assert.AreEqual(false, StringEndsWithTask.Solution("sumo", "omo"));
        Assert.AreEqual(false, StringEndsWithTask.Solution("ails", "fails"));
        Assert.AreEqual(true, StringEndsWithTask.Solution("ninja", "ja"));
        Assert.AreEqual(true, StringEndsWithTask.Solution("!@#$%^&*() :-)", ":-)"));
    }
}