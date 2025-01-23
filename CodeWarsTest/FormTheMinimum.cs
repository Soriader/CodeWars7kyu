using CodeWars7kyu;

namespace CodeWarsTest;

public class FormTheMinimum
{
    [Test]
    public void FormTheMinimumTest()
    {
        Assert.AreEqual(13, FormTheMinimumTask.MinValue(new int[] { 1, 3, 1 }));
        Assert.AreEqual(457, FormTheMinimumTask.MinValue(new int[] { 4, 7, 5, 7 }));
        Assert.AreEqual(148, FormTheMinimumTask.MinValue(new int[] { 4, 8, 1, 4 }));
        Assert.AreEqual(579, FormTheMinimumTask.MinValue(new int[] { 5, 7, 9, 5, 7 }));
    }
}