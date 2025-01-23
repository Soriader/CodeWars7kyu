namespace CodeWarsTest;

using CodeWars7kyu;

public class CogsOneTest
{
    [Test]
    public void CogsTest()
    {
        double expected = -4.0 / 3;
        Assert.That(CogsTask.CogRpm(new[] { 100, 75 }), Is.EqualTo(expected).Within(1e-6));
    }
}