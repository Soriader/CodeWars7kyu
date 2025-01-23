using CodeWars7kyu;

namespace CodeWarsTest;

public class SumOfCubes
{
    [Test]
    public void SumOfCubesTest()
    {
        Assert.AreEqual(1, SumOfCubesTask.SumCubes(1));
        Assert.AreEqual(9, SumOfCubesTask.SumCubes(2));
        Assert.AreEqual(36, SumOfCubesTask.SumCubes(3));
        Assert.AreEqual(100, SumOfCubesTask.SumCubes(4));
        Assert.AreEqual(3025, SumOfCubesTask.SumCubes(10));
        Assert.AreEqual(58155876, SumOfCubesTask.SumCubes(123));
    }
}