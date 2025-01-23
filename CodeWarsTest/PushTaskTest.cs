using CodeWars7kyu;

namespace CodeWarsTest;

public class PushTaskTest
{
    [Test]
    public void PushTests()
    {
        Assert.AreEqual(1, LinkedListsPushBuildOneTwoThreeTask.Push(null, 1).Data, "Should be able to create a new linked list with push().");
        Assert.AreEqual(null, LinkedListsPushBuildOneTwoThreeTask.Push(null, 1).Next, "Should be able to create a new linked list with push().");
        Assert.AreEqual(2, LinkedListsPushBuildOneTwoThreeTask.Push(new LinkedListsPushBuildOneTwoThreeTask(1), 2).Data, "Should be able to prepend a node to an existing node.");
        Assert.AreEqual(1, LinkedListsPushBuildOneTwoThreeTask.Push(new LinkedListsPushBuildOneTwoThreeTask(1), 2).Next.Data, "Should be able to prepend a node to an existing node.");

        Assert.AreEqual(1, LinkedListsPushBuildOneTwoThreeTask.BuildOneTwoThree().Data, "First node should should have 1 as data.");
        Assert.AreEqual(2, LinkedListsPushBuildOneTwoThreeTask.BuildOneTwoThree().Next.Data, "Second node should should have 2 as data.");
        Assert.AreEqual(3, LinkedListsPushBuildOneTwoThreeTask.BuildOneTwoThree().Next.Next.Data, "Third node should should have 3 as data.");
        Assert.AreEqual(null, LinkedListsPushBuildOneTwoThreeTask.BuildOneTwoThree().Next.Next.Next, "Third node should be the tail of the linked list");
    }
}