namespace CodeWarsTest;
using CodeWars7kyu;

public class HowManyEmailsWeSentToday
{
    [Test]
    public void HowManyEmailsWeSentTodayTest()
    {
        Assert.That(HowManyEmailsWeSentTodayTask.CountEmails(100, 1000), Is.EqualTo("10%"));
    }
}