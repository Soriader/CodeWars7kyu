using CodeWars7kyu;

namespace CodeWarsTest;

public class RetrieveArrayValueByIndexWithDefault
{
    [Test]
    public void RetrieveArrayValueByIndexWithDefaultTest()
    {
        int[] range = Enumerable.Range(1, 3).ToArray();
        Assert.AreEqual(2, RetrieveArrayValueByIndexWithDefaultTask.Solution(range, 1, -1));
        Assert.AreEqual(3, RetrieveArrayValueByIndexWithDefaultTask.Solution(range, -1, -1));
        Assert.AreEqual(-1, RetrieveArrayValueByIndexWithDefaultTask.Solution(range, -5, -1));
        Assert.AreEqual(1, RetrieveArrayValueByIndexWithDefaultTask.Solution(range, -3, -1));
    }
}