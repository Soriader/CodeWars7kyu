using CodeWars7kyu;

namespace CodeWarsTest;

public class FilterTheNumber
{
    [Test]
    public static void FilterTheNumberTest()
    {
        Assert.AreEqual(123, FilterTheNumberTask.FilterString("123"), "Just return the numbers");
        Assert.AreEqual(123, FilterTheNumberTask.FilterString("a1b2c3"), "Just return the numbers");
        Assert.AreEqual(123, FilterTheNumberTask.FilterString("aa1bb2cc3dd"), "Just return the numbers");
    }
}