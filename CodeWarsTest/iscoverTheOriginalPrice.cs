using CodeWars7kyu;

namespace CodeWarsTest;

public class iscoverTheOriginalPrice
{
    [Test]
    public void DiscoverTheOriginalPriceTest()
    {
        Assert.AreEqual(100.00M, DiscoverTheOriginalPriceTask.DiscoverOriginalPrice(75M, 25M));
    }
}