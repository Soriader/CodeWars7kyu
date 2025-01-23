using CodeWars7kyu;

namespace CodeWarsTest;

public class GoingToTheCinema
{
    [Test]
    public static void GoingToTheCinemaTest()
    {
        Assert.AreEqual(43, GoingToTheCinemaTask.Movie(500, 15, 0.9));
        Assert.AreEqual(24, GoingToTheCinemaTask.Movie(100, 10, 0.95));

    }
}