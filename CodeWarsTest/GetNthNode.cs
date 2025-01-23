using CodeWars7kyu;

namespace CodeWarsTest;

public class GetNthNode
{
    [Test]
    public void GetNthNodeTest()
    {
        GetNthNodeTask head = new GetNthNodeTask(1);
        head.Next = new GetNthNodeTask(2);
        head.Next.Next = new GetNthNodeTask(3);

        GetNthNodeTask result = GetNthNodeTask.GetNth(head, 0);
        Assert.AreEqual(1, result.Data);

        result = GetNthNodeTask.GetNth(head, 1);
        Assert.AreEqual(2, result.Data);

        result = GetNthNodeTask.GetNth(head, 2);
        Assert.AreEqual(3, result.Data);
    }
}