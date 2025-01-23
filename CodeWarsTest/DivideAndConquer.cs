using CodeWars7kyu;

namespace CodeWarsTest;

public class DivideAndConquer
{
    [Test]
    public void DivideAndConquerTest()
    {
        Assert.AreEqual(2, DivideAndConquerTask.DivCon(new object[] { 9, 3, "7", "3" }));
        Assert.AreEqual(14, DivideAndConquerTask.DivCon(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
        Assert.AreEqual(13, DivideAndConquerTask.DivCon(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
        Assert.AreEqual(11, DivideAndConquerTask.DivCon(new object[] { "1", "5", "8", 8, 9, 9, 2, "3" }));
        Assert.AreEqual(61, DivideAndConquerTask.DivCon(new object[] { 8, 0, 0, 8, 5, 7, 2, 3, 7, 8, 6, 7 }));
        Assert.AreEqual(-6, DivideAndConquerTask.DivCon(new object[] { "0", "1", "2", "3" }));
        Assert.AreEqual(6, DivideAndConquerTask.DivCon(new object[] { 0, 1, 2, 3 }));
        Assert.AreEqual(0, DivideAndConquerTask.DivCon(new object[] { 1, "1" }));
        Assert.AreEqual(-2, DivideAndConquerTask.DivCon(new object[] { -1, "1" }));
        Assert.AreEqual(2, DivideAndConquerTask.DivCon(new object[] { 1, "-1" }));
        Assert.AreEqual(1, DivideAndConquerTask.DivCon(new object[] { 1 }));
        Assert.AreEqual(-1, DivideAndConquerTask.DivCon(new object[] { "1" }));
        Assert.AreEqual(0, DivideAndConquerTask.DivCon(new object[] { }));
    }
}