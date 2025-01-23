namespace CodeWarsTest;

using CodeWars7kyu;

public class InertialArrayTest
{
    [Test]
    public void InertialArray()
    {
        Assert.That(InertialArrayTask.IsInertial(new int[] { 11, 4, 20, 9, 2, 8 }), Is.EqualTo(true));
    }
}