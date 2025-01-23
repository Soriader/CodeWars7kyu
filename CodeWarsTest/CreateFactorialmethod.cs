using CodeWars7kyu;

namespace CodeWarsTest;

public class CreateFactorialmethod
{
    [Test]
    public void CreateFactorialmethodTest()
    {
        Assert.AreEqual(1, CreateFactorialmethodTask.Factorial(0));
        Assert.AreEqual(1, CreateFactorialmethodTask.Factorial(1));
        Assert.AreEqual(2, CreateFactorialmethodTask.Factorial(2));
        Assert.AreEqual(6, CreateFactorialmethodTask.Factorial(3));
        Assert.AreEqual(24, CreateFactorialmethodTask.Factorial(4));
        Assert.AreEqual(120, CreateFactorialmethodTask.Factorial(5));
    }
}