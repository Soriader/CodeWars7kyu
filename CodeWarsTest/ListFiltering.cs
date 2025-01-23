using CodeWars7kyu;

namespace CodeWarsTest;

public class ListFiltering
{
    [Test]
    public void ListFilteringTest()
    {
        var list = new List<object>() { 1, 2, "a", "b" };
        var expected = new List<int>() { 1, 2 };
        var actual = ListFilteringTask.GetIntegersFromList(list);
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
}