using CodeWars7kyu;

namespace CodeWarsTest;

public class PlusMinusCount
{
    [Test]
    public void PlusMinusCountTest()
    {
        Assert.AreEqual(1, PlusMinusCountTask.CatchSignChange(new int[] { 2, 6, 3, 0, 5, -3 }));
        Assert.AreEqual(1, PlusMinusCountTask.CatchSignChange(new int[] { -2, -2, -5, -4, 5, 2, 0, 6, 0 }));
        Assert.AreEqual(2, PlusMinusCountTask.CatchSignChange(new int[] { 3, 7, -6, 2, 3, 1, 1 }));
        Assert.AreEqual(2, PlusMinusCountTask.CatchSignChange(new int[] { -1, 2, 2, 0, 2, -8, -1 }));
        Assert.AreEqual(3, PlusMinusCountTask.CatchSignChange(new int[] { -47, 84, -30, -11, -5, 74, 77 }));
        Assert.AreEqual(4, PlusMinusCountTask.CatchSignChange(new int[] { -8, 4, -1, 5, -3, -3, -2, -2 }));

    }
}