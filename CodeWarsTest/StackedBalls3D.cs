namespace CodeWarsTest;

using CodeWars7kyu;

public class StackedBalls3D
{
    private static double EPSILON = 0.001;

    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(StackedBalls3DTask.StackHeight3d(1), Is.EqualTo(1.0).Within(EPSILON));
    }

    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(StackedBalls3DTask.StackHeight3d(2), Is.EqualTo(1.7071).Within(EPSILON));
    }
}