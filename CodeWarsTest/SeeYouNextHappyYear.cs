using CodeWars7kyu;

namespace CodeWarsTest;

public class SeeYouNextHappyYear
{
    [Test]
    public void SeeYouNextHappyYearTest()
    {
        SeeYouNextHappyYearTask kata = new SeeYouNextHappyYearTask();

        Assert.AreEqual(kata.NextHappyYear(1001), 1023);
        Assert.AreEqual(kata.NextHappyYear(1123), 1203);
        Assert.AreEqual(kata.NextHappyYear(2001), 2013);
        Assert.AreEqual(kata.NextHappyYear(2334), 2340);
        Assert.AreEqual(kata.NextHappyYear(3331), 3401);
        Assert.AreEqual(kata.NextHappyYear(2342), 2345);
        Assert.AreEqual(kata.NextHappyYear(1987), 2013);
        Assert.AreEqual(kata.NextHappyYear(2013), 2014);
        Assert.AreEqual(kata.NextHappyYear(3000), 3012);
    }
}