using CodeWars7kyu;

namespace CodeWarsTest;

public class TestToValidSpacing
{
    [Test]
    public void TestToValidSpacingTest()
    {
        TestToValidSpacingTask(true, "Hello world");
        TestToValidSpacingTask(false, " Hello world");
        TestToValidSpacingTask(false, "Hello world ");
        TestToValidSpacingTask(true, "Hello");
        TestToValidSpacingTask(true, "Helloworld");

        void TestToValidSpacingTask(bool solution, string input)
        {
            Assert.AreEqual(solution, ValidSpacingTask.ValidSpacing(input), $"Incorrect answer for input \"{input}\"");
        }
    }
}