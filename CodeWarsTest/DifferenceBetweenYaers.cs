using CodeWars7kyu;

namespace CodeWarsTest;

public class DifferenceBetweenYaers
{
    [Test]
    public void DifferenceBetweenYaersTest()
    {
        Assert.AreEqual(18, DifferenceBetweenYaersTask.HowManyYears("1997/10/10", "2015/10/10"));
        Assert.AreEqual(25, DifferenceBetweenYaersTask.HowManyYears("1990/10/10", "2015/10/10"));
        Assert.AreEqual(25, DifferenceBetweenYaersTask.HowManyYears("2015/10/10", "1990/10/10"));
        Assert.AreEqual(23, DifferenceBetweenYaersTask.HowManyYears("1992/10/24", "2015/10/24"));
        Assert.AreEqual(18, DifferenceBetweenYaersTask.HowManyYears("2018/10/10", "2000/10/10"));
        Assert.AreEqual(0, DifferenceBetweenYaersTask.HowManyYears("2000/10/10", "2000/10/10"));
    }
}