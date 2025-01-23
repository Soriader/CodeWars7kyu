using CodeWars7kyu;

namespace CodeWarsTest;

public class SortAndTransform
{
    [Test]
    public void SortAndTransformTest()
    {
        Assert.AreEqual("3>c~-3>d~-~d>3-3>d~", SortAndTransformTask.SortTransform(new[] { 51, 62, 73, 84, 95, 100, 99, 126 }));
      
    }
}