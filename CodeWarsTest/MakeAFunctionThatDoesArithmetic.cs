using CodeWars7kyu;

namespace CodeWarsTest;

public class MakeAFunctionThatDoesArithmetic
{
    [Test]
    public void MakeAFunctionThatDoesArithmeticTest()
    {
        Assert.AreEqual(3, MakeAFunctionThatDoesArithmeticTask.Arithmetic(1, 2, "add"));
        Assert.AreEqual(6, MakeAFunctionThatDoesArithmeticTask.Arithmetic(8, 2, "subtract"));
        Assert.AreEqual(10, MakeAFunctionThatDoesArithmeticTask.Arithmetic(5, 2, "multiply"));
        Assert.AreEqual(4, MakeAFunctionThatDoesArithmeticTask.Arithmetic(8, 2, "divide"));
    }
}