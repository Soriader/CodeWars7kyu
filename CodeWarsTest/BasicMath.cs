using CodeWars7kyu;

namespace CodeWarsTest;

public class BasicMath
{
    [Test]
    public void BasicMathTest()
    {
        Test("10", "1plus2plus3plus4");
        Test("-8", "1minus2minus3minus4");
        Test("2", "1plus2plus3minus4");
        Test("-2", "1minus2plus3minus4");
        Test("-1", "1plus2minus3plus4minus5");

        void Test(string solution, string input)
        {
            Assert.AreEqual(solution, BasicMathTask.Calculate(input), $"Incorrect answer for input \"{input}\"");
        }
    }
}