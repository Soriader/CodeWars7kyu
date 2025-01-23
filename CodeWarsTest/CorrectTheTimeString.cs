using CodeWars7kyu;

namespace CodeWarsTest;

public class CorrectTheTimeString
{
    [Test]
    public void CorrectTheTimeStringTest()
    {
        Assert.AreEqual("09:10:01", CorrectTheTimeStringTask.Correct("09:10:01"));
        Assert.AreEqual("12:10:10", CorrectTheTimeStringTask.Correct("11:70:10"));
        Assert.AreEqual("20:40:39", CorrectTheTimeStringTask.Correct("19:99:99"));
        Assert.AreEqual("00:01:01", CorrectTheTimeStringTask.Correct("24:01:01"));
        Assert.AreEqual("04:01:01", CorrectTheTimeStringTask.Correct("52:01:01"));

        Assert.AreEqual(null, CorrectTheTimeStringTask.Correct("001122"));
        Assert.AreEqual(null, CorrectTheTimeStringTask.Correct("00;11;22"));
        Assert.AreEqual(null, CorrectTheTimeStringTask.Correct("0a:1c:22"));

        Assert.AreEqual("", CorrectTheTimeStringTask.Correct(""));

        Assert.AreEqual(null, CorrectTheTimeStringTask.Correct(null));

    }
}