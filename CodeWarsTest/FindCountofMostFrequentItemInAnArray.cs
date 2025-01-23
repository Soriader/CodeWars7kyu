using CodeWars7kyu;

namespace CodeWarsTest;

public class FindCountofMostFrequentItemInAnArray
{
    [Test]
    public void FindCountofMostFrequentItemInAnArrayTest()
    {
        Assert.AreEqual(5, FindCountofMostFrequentItemInAnArrayTask.MostFrequentItemCount(new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 }));
    }
}