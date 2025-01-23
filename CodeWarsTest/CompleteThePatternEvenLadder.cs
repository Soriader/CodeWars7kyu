using CodeWars7kyu;

namespace CodeWarsTest;

public class CompleteThePatternEvenLadder
{
    [Test]
    public void CompleteThePatternEvenLadderTest()
    {
        Assert.AreEqual("22", CompleteThePatternEvenLadderTask.Pattern(2));
        Assert.AreEqual("", CompleteThePatternEvenLadderTask.Pattern(1));
        Assert.AreEqual("22\n4444", CompleteThePatternEvenLadderTask.Pattern(5));
        Assert.AreEqual("", CompleteThePatternEvenLadderTask.Pattern(0));
        Assert.AreEqual("", CompleteThePatternEvenLadderTask.Pattern(-25));
    }
}