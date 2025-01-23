using CodeWars7kyu;

namespace CodeWarsTest;

public class WeHaveLiftoff
{
    [Test]
    public void WeHaveLiftoffTest()
    {
        Assert.AreEqual("10 9 8 7 6 5 4 3 2 1 liftoff!", WeHaveLiftoffTask.Liftoff(new List<int> { 2, 8, 10, 9, 1, 3, 4, 7, 6, 5 }));

    }
}