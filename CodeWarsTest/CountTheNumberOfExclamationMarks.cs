using CodeWars7kyu;

namespace CodeWarsTest;

public class CountTheNumberOfExclamationMarks
{
    [Test]
    public void CountTheNumberOfExclamationMarksTest()
    {
        Assert.AreEqual(0, CountTheNumberOfExclamationMarksTask.Product(""));
        Assert.AreEqual(1, CountTheNumberOfExclamationMarksTask.Product("!?"));
        Assert.AreEqual(2, CountTheNumberOfExclamationMarksTask.Product("!??"));
        Assert.AreEqual(2, CountTheNumberOfExclamationMarksTask.Product("!!?"));
        Assert.AreEqual(6, CountTheNumberOfExclamationMarksTask.Product("!!???"));
        Assert.AreEqual(6, CountTheNumberOfExclamationMarksTask.Product("!!!??"));
        Assert.AreEqual(4, CountTheNumberOfExclamationMarksTask.Product("!!??"));
        Assert.AreEqual(4, CountTheNumberOfExclamationMarksTask.Product("!????"));
        Assert.AreEqual(4, CountTheNumberOfExclamationMarksTask.Product("!!!!?"));
        Assert.AreEqual(5, CountTheNumberOfExclamationMarksTask.Product("!?????"));
        Assert.AreEqual(20, CountTheNumberOfExclamationMarksTask.Product("!!????!!?"));
        Assert.AreEqual(49, CountTheNumberOfExclamationMarksTask.Product("!!???????!!!!!"));
        Assert.AreEqual(165, CountTheNumberOfExclamationMarksTask.Product("!!???????????!!!!!?!?!?!?!"));
        Assert.AreEqual(4, CountTheNumberOfExclamationMarksTask.Product("!!aabbcc??"));
        Assert.AreEqual(4, CountTheNumberOfExclamationMarksTask.Product("! !aa bb   c c??   "));
    }
}