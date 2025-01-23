using CodeWars7kyu;

namespace CodeWarsTest;

public class MontyHallProblem
{
    [Test]
    public void MontyHallProblemTest()
    {
        Assert.AreEqual(71, MontyHallProblemTask.MontyHall(1, new int[] { 3, 3, 2, 3, 3, 2, 2, 3, 2, 2, 1, 1, 1, 1 }));
        Assert.AreEqual(64, MontyHallProblemTask.MontyHall(2, new int[] { 3, 3, 2, 3, 3, 2, 2, 3, 2, 2, 1, 1, 1, 1 }));
        Assert.AreEqual(64, MontyHallProblemTask.MontyHall(3, new int[] { 3, 3, 2, 3, 3, 2, 2, 3, 2, 2, 1, 1, 1, 1 }));

    }
}