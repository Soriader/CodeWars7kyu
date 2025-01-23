using CodeWars7kyu;

namespace CodeWarsTest;

public class CartesianNeighbors
{
    [Test]
    public void CartesianNeighborsTest()
    {
        var r = new List<int[]>{
            new int[]{1,1},
            new int[]{1,2},
            new int[]{1,3},
            new int[]{2,1},
            new int[]{2,3},
            new int[]{3,1},
            new int[]{3,2},
            new int[]{3,3},
        };
        Assert.AreEqual(r, CartesianNeighborsTask.CartesianNeighbor(2, 2));
    }
}