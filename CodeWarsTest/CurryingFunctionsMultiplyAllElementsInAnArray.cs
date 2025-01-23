using CodeWars7kyu;

namespace CodeWarsTest;

public class CurryingFunctionsMultiplyAllElementsInAnArray
{
    [Test]
    public void CurryingFunctionsMultiplyAllElementsInAnArrayTest()
    {
        Assert.AreEqual(new int[] { 1, 2, 3 }, CurryingFunctionsMultiplyAllElementsInAnArrayTask.MultiplyAll(new int[] { 1, 2, 3 })(1));
        Assert.AreEqual(new int[] { 2, 4, 6 }, CurryingFunctionsMultiplyAllElementsInAnArrayTask.MultiplyAll(new int[] { 1, 2, 3 })(2));
        Assert.AreEqual(new int[] { 0, 0, 0 }, CurryingFunctionsMultiplyAllElementsInAnArrayTask.MultiplyAll(new int[] { 1, 2, 3 })(0));
        Assert.AreEqual(new int[] { }, CurryingFunctionsMultiplyAllElementsInAnArrayTask.MultiplyAll(new int[] { })(10));

    }
}