using CodeWars7kyu;

namespace CodeWarsTest;

public class CheckTheExam
{
    [Test]
    public void CheckTheExamTest()
    {
        Assert.AreEqual(7, CheckTheExamTask.CheckExam(new string[] { "a", "a", "c", "b" }, new string[] { "a", "a", "b", "" }));
        Assert.AreEqual(6, CheckTheExamTask.CheckExam(new string[] { "a", "a", "b", "b" }, new string[] { "a", "c", "b", "d" }));
        Assert.AreEqual(0, CheckTheExamTask.CheckExam(new string[] { "b", "c", "b", "a" }, new string[] { "", "a", "a", "c" }));
    }
}