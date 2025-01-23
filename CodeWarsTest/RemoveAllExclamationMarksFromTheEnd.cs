using CodeWars7kyu;

namespace CodeWarsTest;

public class RemoveAllExclamationMarksFromTheEnd
{
    [Test]
    public void RemoveAllExclamationMarksFromTheEndTest()
    {
        Assert.AreEqual("!!!Hi !!hi !hi", RemoveAllExclamationMarksFromTheEndTask.Remove("!!!Hi !!hi!!! !hi"));
        Assert.AreEqual("Hi", RemoveAllExclamationMarksFromTheEndTask.Remove("Hi!"));
        Assert.AreEqual("!Hi", RemoveAllExclamationMarksFromTheEndTask.Remove("!Hi!"));
    }
}