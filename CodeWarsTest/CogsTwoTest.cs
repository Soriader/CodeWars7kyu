namespace CodeWarsTest;

using CodeWars7kyu;

public class CogsTwoTest
{
    [Test]
    public void CogsTwo()
    {
        double delta = 1e-9;
        double[] expected = new[] { -1.0 / 2, -2.0 };
        var actual = CogsTwoTask.CogRpm(new[] { 100, 50, 25 }, 1);
        Assert.That(actual.Length, Is.EqualTo(2));
        Assert.That(actual[0], Is.EqualTo(expected[0]).Within(delta));
        Assert.That(actual[1], Is.EqualTo(expected[1]).Within(delta));
    }
}