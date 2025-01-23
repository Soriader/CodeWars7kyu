using CodeWars7kyu;

namespace CodeWarsTest;

public class AreaOfACircle
{
    [Test]
    public void AreaOfACircleTest()
    {
        Assert.AreEqual(3.141, AreaOfACircleTask.CalculateAreaOfCircle(1), 0.01);
        Assert.AreEqual(5881.248, AreaOfACircleTask.CalculateAreaOfCircle(43.2673), 0.01);
        Assert.AreEqual(14526.724, AreaOfACircleTask.CalculateAreaOfCircle(68), 0.01);
        Assert.Throws<ArgumentException>(() => AreaOfACircleTask.CalculateAreaOfCircle(0));
        Assert.Throws<ArgumentException>(() => AreaOfACircleTask.CalculateAreaOfCircle(-1));


    }
}