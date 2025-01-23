using CodeWars7kyu;

namespace CodeWarsTest;

public class HeadTailInitLast
{
    [Test]
    public void HeadTailInitLastTest()
    {
        Assert.AreEqual(5, HeadTailInitLastTask.Head(new List<int> { 5, 1 }));
        Assert.AreEqual(new List<int> { 2, 3 }, HeadTailInitLastTask.Tail(new List<int> { 1, 2, 3 }));
        Assert.AreEqual(new List<int> { 1, 5, 7 }, HeadTailInitLastTask.Init(new List<int> { 1, 5, 7, 9 }));
        Assert.AreEqual(2, HeadTailInitLastTask.GetLast(new List<int> { 7, 2 }));
    }
}