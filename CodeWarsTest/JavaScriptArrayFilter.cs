using CodeWars7kyu;

namespace CodeWarsTest;

public class JavaScriptArrayFilter
{
    [Test]
    public void JavaScriptArrayFilterTest()
    {
        Assert.AreEqual(new int[] { 2 }, JavaScriptArrayFilterTask.GetEvenNumbers(new int[] { 1, 2 }));
        Assert.AreEqual(new int[] { 2, 6, 8, 10 }, JavaScriptArrayFilterTask.GetEvenNumbers(new int[] { 2, 6, 8, 10 }));
        Assert.AreEqual(new int[] { 12, 14 }, JavaScriptArrayFilterTask.GetEvenNumbers(new int[] { 12, 14, 15 }));
        Assert.AreEqual(new int[] { }, JavaScriptArrayFilterTask.GetEvenNumbers(new int[] { 1, 3, 9 }));

    }
}