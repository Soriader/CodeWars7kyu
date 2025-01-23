using CodeWars7kyu;

namespace CodeWarsTest;

public class ThePoetAndThePendulum
{
    [Test]
    public void ThePoetAndThePendulumTest()
    {
        Assert.AreEqual(new[] { 10, 4, 9 }, ThePoetAndThePendulumTask.Pendulum(new[] { 4, 10, 9 }));
        Assert.AreEqual(new[] { 8, 3, 7, 10 }, ThePoetAndThePendulumTask.Pendulum(new[] { 8, 7, 10, 3 }));
        Assert.AreEqual(new[] { 10, 6, 5, 6, 8 }, ThePoetAndThePendulumTask.Pendulum(new[] { 6, 6, 8, 5, 10 }));
        Assert.AreEqual(new[] { 9, 5, 4, 4, 6, 10 }, ThePoetAndThePendulumTask.Pendulum(new[] { 9, 4, 6, 4, 10, 5 }));
        Assert.AreEqual(new[] { 8, 6, 4, 5, 7 }, ThePoetAndThePendulumTask.Pendulum(new[] { 4, 6, 8, 7, 5 }));
        Assert.AreEqual(new[] { 10, 5, 6, 10 }, ThePoetAndThePendulumTask.Pendulum(new[] { 10, 5, 6, 10 }));
        Assert.AreEqual(new[] { 12, 11, 12 }, ThePoetAndThePendulumTask.Pendulum(new[] { 11, 12, 12 }));
    }
}