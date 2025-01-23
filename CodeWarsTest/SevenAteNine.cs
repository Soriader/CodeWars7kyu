using CodeWars7kyu;

namespace CodeWarsTest;

public class SevenAteNine
{
    [Test]
    public void SevenAteNineTest()
    {
        Assert.AreEqual("77", SevenAteNineTask.SevenAteNine("797"));
        Assert.AreEqual("7777", SevenAteNineTask.SevenAteNine("7979797"));
        Assert.AreEqual("16556178612178977", SevenAteNineTask.SevenAteNine("165561786121789797"));

    }
}