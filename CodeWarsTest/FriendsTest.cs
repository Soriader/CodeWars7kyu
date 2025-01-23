namespace CodeWarsTest;

using CodeWars7kyu;

public class FriendsTest
{
    [Test]
    public void Friends()
    {
        Assert.That(FriendsTask.Friends(0), Is.EqualTo(0));
        Assert.That(FriendsTask.Friends(1), Is.EqualTo(0));
        Assert.That(FriendsTask.Friends(2), Is.EqualTo(0));
        Assert.That(FriendsTask.Friends(4), Is.EqualTo(1));
        Assert.That(FriendsTask.Friends(2570), Is.EqualTo(11));
    }
}