using CodeWars7kyu;

namespace CodeWarsTest;

public class WhoIsOnline
{
    [Test]
    public void WhoIsOnlineTest()
    {
        WhoIsOnlineTask.User[] friends = new WhoIsOnlineTask.User[]
        {
            new WhoIsOnlineTask.User("David", WhoIsOnlineTask.User.UserStatus.Online, 10),
            new WhoIsOnlineTask.User("Lucy", WhoIsOnlineTask.User.UserStatus.Offline, 22),
            new WhoIsOnlineTask.User("Bob", WhoIsOnlineTask.User.UserStatus.Online, 104)
        };
        var expected = new Dictionary<WhoIsOnlineTask.User.UserStatus, IEnumerable<string>>
        {
            {WhoIsOnlineTask.User.UserStatus.Online, new[] {"David"}},
            {WhoIsOnlineTask.User.UserStatus.Offline, new[] {"Lucy"}},
            {WhoIsOnlineTask.User.UserStatus.Away, new[] {"Bob"}}
        };
        Assert.That(WhoIsOnlineTask.User.WhosOnline(friends), Is.EqualTo(expected));
    }
}