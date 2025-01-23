using CodeWars7kyu;

namespace CodeWarsTest;

public class LoveVsFriendship
{
    [Test]
    public void LoveVsFriendshipTest()
    {
        Assert.AreEqual(100, LoveVsFriendshipTask.WordsToMarks("attitude"));
        Assert.AreEqual(75, LoveVsFriendshipTask.WordsToMarks("friends"));
        Assert.AreEqual(66, LoveVsFriendshipTask.WordsToMarks("family"));
        Assert.AreEqual(96, LoveVsFriendshipTask.WordsToMarks("knowledge"));

    }
}