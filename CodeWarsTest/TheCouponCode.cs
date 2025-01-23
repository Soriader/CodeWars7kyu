using CodeWars7kyu;

namespace CodeWarsTest;

public class TheCouponCode
{
    [Test]
    public static void TheCouponCodeTest()
    {
        Assert.AreEqual(true, TheCouponCodeTask.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));
        Assert.AreEqual(false, TheCouponCodeTask.CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"));

    }
}