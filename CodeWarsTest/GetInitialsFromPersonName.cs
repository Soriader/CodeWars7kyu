using CodeWars7kyu;

namespace CodeWarsTest;

public class GetInitialsFromPersonName
{
    [Test]
    public void GetInitialsFromPersonNameTest()
    {
        Assert.AreEqual(GetInitialsFromPersonNameTask.ToInitials("Kerry King"), "K. K.");
        Assert.AreEqual(GetInitialsFromPersonNameTask.ToInitials("Tom Araya"), "T. A.");
    }
}