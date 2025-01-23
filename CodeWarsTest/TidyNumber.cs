using CodeWars7kyu;

namespace CodeWarsTest;

public class TidyNumber
{
    [Test]
    public void TidyNumberTest()
    {
        Assert.AreEqual(false, TidyNumberTask.TidyNumber(102));
        Assert.AreEqual(false, TidyNumberTask.TidyNumber(9672));
        Assert.AreEqual(true, TidyNumberTask.TidyNumber(12));
        Assert.AreEqual(true, TidyNumberTask.TidyNumber(2789));

    }
}