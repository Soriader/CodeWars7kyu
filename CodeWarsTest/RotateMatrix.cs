using CodeWars7kyu;

namespace CodeWarsTest;

public class RotateMatrix
{
    [Test]
    public void RotateMatrixTest()
    {
        int[,] oldMatrix = new int[4, 4]
        {{-1,4,3,4},
            {5,6,7,8},
            {2,5,1,7},
            {3,14,-5,3}};
        int[,] newMatrix = new int[4, 4]
        {{4,8,7,3},
            {3,7,1,-5},
            {4,6,5,14},
            {-1,5,2,3}};
        Assert.AreEqual(newMatrix, new RotateMatrixTask().RotateMatrixLeft(oldMatrix));
    }
}