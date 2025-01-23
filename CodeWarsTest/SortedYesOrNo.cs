using CodeWars7kyu;

namespace CodeWarsTest;

public class SortedYesOrNo
{
    [Test]
    public void SortedYesOrNoTest()
    {
        Assert.AreEqual("yes, ascending", SortedYesOrNoTask.IsSortedAndHow(new[] { 1, 2 }));
        Assert.AreEqual("yes, descending", SortedYesOrNoTask.IsSortedAndHow(new[] { 15, 7, 3, -8 }));
        Assert.AreEqual("no", SortedYesOrNoTask.IsSortedAndHow(new[] { 4, 2, 30 }));
    }
}