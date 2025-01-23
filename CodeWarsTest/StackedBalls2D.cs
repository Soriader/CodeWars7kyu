using CodeWars7kyu;

namespace CodeWarsTest;

public class StackedBalls2D
{
    [Test]
    public void StackedBalls2DTest()
    {
        double EPSILON = 0.001;

        Assert.AreEqual(1.866, StackedBalls2DTask.StackHeight2d(2), EPSILON);
        Assert.AreEqual(1.0, StackedBalls2DTask.StackHeight2d(1), EPSILON);

    }
}