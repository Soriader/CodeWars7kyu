using CodeWars7kyu;

namespace CodeWarsTest;

public class CheckThreeAndTwo
{
    [Test]
    public void CheckThreeAndTwoTest()
    {
        Assert.AreEqual(true, CheckThreeAndTwoTask.CheckThreeAndTwo(new string[] { "a", "a", "a", "b", "b" }));
        Assert.AreEqual(false, CheckThreeAndTwoTask.CheckThreeAndTwo(new string[] { "a", "c", "a", "c", "b" }));
        Assert.AreEqual(false, CheckThreeAndTwoTask.CheckThreeAndTwo(new string[] { "a", "a", "a", "a", "a" }));
    }
}