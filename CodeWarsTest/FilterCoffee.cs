using CodeWars7kyu;

namespace CodeWarsTest;

public class FilterCoffee
{
    [Test]
    public void FilterCoffeeTest()
    {
        Assert.AreEqual("1,2,2", FilterCoffeeTask.Search(3, new int[] { 6, 1, 2, 9, 2 }));
        Assert.AreEqual("3,7,7,9,14", FilterCoffeeTask.Search(14, new int[] { 7, 3, 23, 9, 14, 20, 7 }));
        Assert.AreEqual("", FilterCoffeeTask.Search(0, new int[] { 6, 1, 2, 9, 2 }));

    }
}