using CodeWars7kyu;

namespace CodeWarsTest;

public class NegationOfAValue
{
    [Test]
    public void NegationOfAValueTest()
    {
        Assert.AreEqual(true, NegationOfAValueTask.NegationValue("!", false));
        Assert.AreEqual(false, NegationOfAValueTask.NegationValue("!", true));
        Assert.AreEqual(true, NegationOfAValueTask.NegationValue("!!!", false));

    }
}