using CodeWars7kyu;

namespace CodeWarsTest;

public class ProductOfLargestPair
{
    [Test]
    public void ProductOfLargestPairTest()
    {
        Assert.AreEqual(218842, ProductOfLargestPairTask.MaxProduct(new int[] { 56, 335, 195, 443, 6, 494, 252 }));
        Assert.AreEqual(194740, ProductOfLargestPairTask.MaxProduct(new int[] { 154, 428, 455, 346 }));
        Assert.AreEqual(187827, ProductOfLargestPairTask.MaxProduct(new int[] { 39, 135, 47, 275, 37, 108, 265, 457, 2, 133, 316, 330, 153, 253, 321, 411 }));
        Assert.AreEqual(87984, ProductOfLargestPairTask.MaxProduct(new int[] { 136, 376, 10, 146, 105, 63, 234 }));
        Assert.AreEqual(218536, ProductOfLargestPairTask.MaxProduct(new int[] { 354, 463, 165, 62, 472, 53, 347, 293, 252, 378, 420, 398, 255, 89 }));
        Assert.AreEqual(192672, ProductOfLargestPairTask.MaxProduct(new int[] { 346, 446, 26, 425, 432, 349, 123, 269, 285, 93, 75, 14 }));
        Assert.AreEqual(95680, ProductOfLargestPairTask.MaxProduct(new int[] { 134, 320, 266, 299 }));
        Assert.AreEqual(139496, ProductOfLargestPairTask.MaxProduct(new int[] { 114, 424, 53, 272, 128, 215, 25, 329, 272, 313, 100, 24, 252 }));
        Assert.AreEqual(174750, ProductOfLargestPairTask.MaxProduct(new int[] { 375, 56, 337, 466, 203 }));
    }
}