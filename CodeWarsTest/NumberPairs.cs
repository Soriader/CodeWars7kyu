using CodeWars7kyu;

namespace CodeWarsTest;

public class NumberPairs
{
    [Test]
    public void NumberPairsTest()
    {
        int[] arr1 = new int[] { 13, 64, 5, 7, 88 };
        int[] arr2 = new int[] { 23, 4, 53, 17, 80 };
        Assert.AreEqual(NumberPairsTask.GetLargerNumbers(arr1, arr2), new int[] { 23, 64, 53, 17, 88 });
    }
}