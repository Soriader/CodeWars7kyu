using CodeWars7kyu;

namespace CodeWarsTest;

public class RemoveWordsFromTheSentenceIfItContainsOneExclamationMark
{
    [Test]
    public void RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTest()
    {
        Assert.AreEqual("", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi!"));
        Assert.AreEqual("", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("!Hi"));
        Assert.AreEqual("", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi! Hi! Hi!"));
        Assert.AreEqual("", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi! !Hi Hi!"));
        Assert.AreEqual("", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi! Hi!"));
        Assert.AreEqual("!Hi!", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("!Hi!"));
        Assert.AreEqual("Hi!!!", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi!!!"));
        Assert.AreEqual("Hi", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi Hi! Hi!"));
        Assert.AreEqual("Hi hi hI", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi hi hI"));
        Assert.AreEqual("Hi!!", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi! Hi!! Hi!"));
        Assert.AreEqual("!Hi!", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi! !Hi! Hi!"));
        Assert.AreEqual("!Hi! !Hi!", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("!Hi! ! !Hi!"));
        Assert.AreEqual("!!!Hi !!hi!!!", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("!!!Hi !!hi!!! !hi"));
    }
}