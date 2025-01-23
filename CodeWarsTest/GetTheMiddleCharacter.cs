using CodeWars7kyu;

namespace CodeWarsTest;

public class GetTheMiddleCharacter
{
    [Test]
    public void GetTheMiddleCharacterTest()
    {
        Assert.AreEqual("es", GetTheMiddleCharacterTask.GetMiddle("test"));
        Assert.AreEqual("t", GetTheMiddleCharacterTask.GetMiddle("testing"));
        Assert.AreEqual("dd", GetTheMiddleCharacterTask.GetMiddle("middle"));
        Assert.AreEqual("A", GetTheMiddleCharacterTask.GetMiddle("A"));
    }
}