using CodeWars7kyu;

namespace CodeWarsTest;

public class Fibonacci
{
    [Test]
    public void FibonacciTest()
    {
        Assert.AreEqual(5, FibonacciTask.Fib(5));
        Assert.AreEqual(55, FibonacciTask.Fib(10));
    }
}