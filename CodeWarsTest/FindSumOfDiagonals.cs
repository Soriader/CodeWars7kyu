using CodeWars7kyu;

namespace CodeWarsTest;

public class FindSumOfDiagonals
{
    [Test]
    public void FindSumOfDiagonalsTest()
    {
        Assert.AreEqual(12, FindSumOfDiagonalsTask.DiagonalSum(new int[,] { { 12 } }));
        Assert.AreEqual(5, FindSumOfDiagonalsTask.DiagonalSum(new int[2, 2] { { 1, 2 }, { 3, 4 } }));
        Assert.AreEqual(15, FindSumOfDiagonalsTask.DiagonalSum(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }));
        Assert.AreEqual(34, FindSumOfDiagonalsTask.DiagonalSum(new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }));
    }
}