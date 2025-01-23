using CodeWars7kyu;

namespace CodeWarsTest;

public class CompleteThePatternThree
{
    [Test]
    public void CompleteThePatternThreeTest()
    {
        Assert.AreEqual("1", CompleteThePatternThreeTask.Pattern(1));
        Assert.AreEqual("2\n21", CompleteThePatternThreeTask.Pattern(2));
        Assert.AreEqual("5\n54\n543\n5432\n54321", CompleteThePatternThreeTask.Pattern(5));
    }
}