using CodeWars7kyu;

namespace CodeWarsTest;

public class DescribeAList
{
    [Test]
    public void DescribeAListTest()
    {
        Assert.AreEqual("empty", DescribeAListTask.DescribeList(new List<int>()));
        Assert.AreEqual("singleton", DescribeAListTask.DescribeList(new List<int>() { 2}));
        Assert.AreEqual("longer", DescribeAListTask.DescribeList(new List<int>() { 2, 3 }));
    }
}