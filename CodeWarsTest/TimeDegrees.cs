namespace CodeWarsTest;

using CodeWars7kyu;

public class TimeDegrees
{
    [Test]
    public void TimeDegreesTest()
    {
        Assert.That(TimeDegreesTask.ClockDegree("01:01"), Is.EqualTo("30:6"));
        Assert.That(TimeDegreesTask.ClockDegree("00:00"), Is.EqualTo("360:360"));
        Assert.That(TimeDegreesTask.ClockDegree("01:03"), Is.EqualTo("30:18"));
        Assert.That(TimeDegreesTask.ClockDegree("01:30"), Is.EqualTo("30:180"));
        Assert.That(TimeDegreesTask.ClockDegree("12:05"), Is.EqualTo("360:30"));
        Assert.That(TimeDegreesTask.ClockDegree("26:78"), Is.EqualTo("Check your time !"));
        Assert.That(TimeDegreesTask.ClockDegree("23:60"), Is.EqualTo("Check your time !"));
        Assert.That(TimeDegreesTask.ClockDegree("24:60"), Is.EqualTo("Check your time !"));
        Assert.That(TimeDegreesTask.ClockDegree("16:25"), Is.EqualTo("120:150"));
        Assert.That(TimeDegreesTask.ClockDegree("17:09"), Is.EqualTo("150:54"));
        Assert.That(TimeDegreesTask.ClockDegree("19:00"), Is.EqualTo("210:360"));
        Assert.That(TimeDegreesTask.ClockDegree("20:34"), Is.EqualTo("240:204"));
        Assert.That(TimeDegreesTask.ClockDegree("23:20"), Is.EqualTo("330:120"));
        Assert.That(TimeDegreesTask.ClockDegree("24:00"), Is.EqualTo("Check your time !"));
        Assert.That(TimeDegreesTask.ClockDegree("-09:00"), Is.EqualTo("Check your time !"));
    }
}