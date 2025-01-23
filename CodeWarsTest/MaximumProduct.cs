using CodeWars7kyu;

namespace CodeWarsTest;

public class MaximumProduct
{
    [Test]
    public void MaximumProductTest()
    {
        Assert.AreEqual(200, MaximumProductTask.AdjacentElementsProduct(new int[] { 40, 5, 8 }));
        Assert.AreEqual(6, MaximumProductTask.AdjacentElementsProduct(new int[] { 6, 1, 2, 3, 0 }));
        Assert.AreEqual(-14, MaximumProductTask.AdjacentElementsProduct(new int[] { -23, 4, -5, 99, -27, 329, -2, 7, -921 }));

    }
}