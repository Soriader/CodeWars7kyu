using CodeWars7kyu;

namespace CodeWarsTest;

public class MultipleOf5
{
    [Test]
    public void MultipleOf5Test()
    {
        Assert.AreEqual(0, MultipleOf5Task.RoundToNext5(0));
        Assert.AreEqual(5, MultipleOf5Task.RoundToNext5(1));
        Assert.AreEqual(5, MultipleOf5Task.RoundToNext5(3));
        Assert.AreEqual(5, MultipleOf5Task.RoundToNext5(5));
        Assert.AreEqual(10, MultipleOf5Task.RoundToNext5(7));
        Assert.AreEqual(40, MultipleOf5Task.RoundToNext5(39));

    }
}