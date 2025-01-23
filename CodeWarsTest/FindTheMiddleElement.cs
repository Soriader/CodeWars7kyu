using CodeWars7kyu;

namespace CodeWarsTest;

public class FindTheMiddleElement
{
    [Test]
    public void FindTheMiddleElementTest()
    {
        Assert.AreEqual(0, FindTheMiddleElementTask.Gimme(new double[] { 2, 3, 1 }));
        Assert.AreEqual(1, FindTheMiddleElementTask.Gimme(new double[] { 5, 10, 14 }));
    }
}