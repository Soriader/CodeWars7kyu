using CodeWars7kyu;

namespace CodeWarsTest;

public class RowSumOddNumbers
{
    [Test]
    public void RowSumOddNumbersTest()
    {
        Assert.AreEqual(1, SumOfOddNumbersTask.RowSumOddNumbers(1));
        Assert.AreEqual(74088, SumOfOddNumbersTask.RowSumOddNumbers(42));
    }
}