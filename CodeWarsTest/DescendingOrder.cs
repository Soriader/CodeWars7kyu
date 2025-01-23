using CodeWars7kyu;

namespace CodeWarsTest;

public class DescendingOrder
{
    [Test]
    public void DescendingOrderTest()
    {
        Assert.AreEqual(0, DescendingOrderTask.DescendingOrder(0));
        Assert.AreEqual(54421, DescendingOrderTask.DescendingOrder(42145));
        Assert.AreEqual(987654321, DescendingOrderTask.DescendingOrder(123456789));
    }
}