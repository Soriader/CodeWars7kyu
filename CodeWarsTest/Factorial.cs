using CodeWars7kyu;

namespace CodeWarsTest;

public class Factorial
{
    [Test]
    public void FactorialTest()
    {
        Assert.AreEqual(1, FactorialTask.Factorial(0));
        Assert.AreEqual(1, FactorialTask.Factorial(1));
        Assert.AreEqual(2, FactorialTask.Factorial(2));
        Assert.AreEqual(6, FactorialTask.Factorial(3));
    }
}