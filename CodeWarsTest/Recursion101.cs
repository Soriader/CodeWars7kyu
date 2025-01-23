using CodeWars7kyu;

namespace CodeWarsTest;

public class Recursion101
{
    [Test]
    public void Recursion101Test()
    {
        Assert.AreEqual((6, 7), Recursion101Task.Solve(6, 19));
        Assert.AreEqual((0, 1), Recursion101Task.Solve(2, 1));
        Assert.AreEqual((0, 1), Recursion101Task.Solve(22, 5));
        Assert.AreEqual((2, 2), Recursion101Task.Solve(2, 10));
        Assert.AreEqual((1019, 1442), Recursion101Task.Solve(8796203, 7556));
        Assert.AreEqual((19394, 19394), Recursion101Task.Solve(19394, 19394));

    }
}