using CodeWars7kyu;

namespace CodeWarsTest;

public class FriendOrFoe
{
    [Test]
    public void FriendOrFoeTest()
    {
        string[] expected = { "Ryan", "Mark" };
        string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
        CollectionAssert.AreEqual(expected, FriendOrFoeTask.FriendOrFoe(names));
    }
}