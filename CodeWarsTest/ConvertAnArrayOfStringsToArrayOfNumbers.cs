using CodeWars7kyu;

namespace CodeWarsTest;

public class ConvertAnArrayOfStringsToArrayOfNumbers
{
    [Test]
    public void ConvertAnArrayOfStringsToArrayOfNumbersTest()
    {
        Assert.AreEqual(new double[] { 1.1, 2.2, 3.3 }, ConvertAnArrayOfStringsToArrayOfNumbersTask.ToDoubleArray(new string[] { "1.1", "2.2", "3.3" }));

    }
}