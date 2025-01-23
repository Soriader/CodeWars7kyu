using CodeWars7kyu;

namespace CodeWarsTest;

public class OddLadder
{
    [Test]
    public void OddLadderTest()
    {
        Assert.AreEqual("1\n333", OddLadderTask.OddLadder(4), "Nope!");
    }
}