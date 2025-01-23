using CodeWars7kyu;

namespace CodeWarsTest;

public class RemoveAllExclamationMarksFromSentenceExceptAtTheEnd
{
    [Test]
    public void RemoveAllExclamationMarksFromSentenceExceptAtTheEndTest()
    {
        Assert.AreEqual("Hi!", RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask.Remove("Hi!"));
        Assert.AreEqual("Hi!!!", RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask.Remove("Hi!!!"));
        Assert.AreEqual("Hi", RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask.Remove("!Hi"));
        Assert.AreEqual("Hi!", RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask.Remove("!Hi!"));
        Assert.AreEqual("Hi Hi!", RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask.Remove("Hi! Hi!"));
        Assert.AreEqual("Hi", RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask.Remove("Hi"));
    }
}