using CodeWars7kyu;

namespace CodeWarsTest;

public class MoveAllExclamationMarksToTheEndOfTheSentence
{
    [Test]
    public void MoveAllExclamationMarksToTheEndOfTheSentenceTest()
    {
        Assert.AreEqual("Hi!", MoveAllExclamationMarksToTheEndOfTheSentenceTask.Remove("Hi!"));
        Assert.AreEqual("Hi Hi!!", MoveAllExclamationMarksToTheEndOfTheSentenceTask.Remove("Hi! Hi!"));
        Assert.AreEqual("Hi Hi Hi!!!", MoveAllExclamationMarksToTheEndOfTheSentenceTask.Remove("Hi! Hi! Hi!"));
        Assert.AreEqual("Hi Hi Hi!!!", MoveAllExclamationMarksToTheEndOfTheSentenceTask.Remove("Hi! !Hi Hi!"));
        Assert.AreEqual("Hi Hi Hi!!!", MoveAllExclamationMarksToTheEndOfTheSentenceTask.Remove("Hi! !Hi Hi!"));
        Assert.AreEqual("Hi Hi Hi!!!!", MoveAllExclamationMarksToTheEndOfTheSentenceTask.Remove("Hi! Hi!! Hi!"));
    }
}