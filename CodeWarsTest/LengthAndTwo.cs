using CodeWars7kyu;

namespace CodeWarsTest;

public class LengthAndTwo
{
    [Test]
    public void LengthAndTwoTest()
    {
        Assertion(new object[] { true, false, true, false, true }, (5, true, false));
        Assertion(new object[] { "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red" }, (20, "blue", "red"));
        Assertion(new object[0], (0, "lemons", "apples"));

        void Assertion(object[] expected, (int, object, object) inputs)
        {
            object[] actual = LengthAndTwoTask.Alternate(inputs.Item1, inputs.Item2, inputs.Item3);
            Assert.AreEqual(
                expected,
                actual,

                $"\n  n = {inputs.Item1}" +
                $"\n  firstValue = {inputs.Item2}" +
                $"\n  secondValue = {inputs.Item3}\n" +
                $"\n  Expected = [{string.Join(", ", expected)}]" +
                $"\n  Actual = [{string.Join(", ", actual)}]\n"

            );
        }
    }
}