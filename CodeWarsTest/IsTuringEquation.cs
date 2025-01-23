using CodeWars7kyu;

namespace CodeWarsTest;

public class IsTuringEquation
{
    [Test]
    public void IsTuringEquationTest()
    {
        Assert.That(IsTuringEquationTask.IsTuringEquation("73+42=16"), Is.EqualTo(true));
        Assert.That(IsTuringEquationTask.IsTuringEquation("5+8=13"), Is.EqualTo(false));
        Assert.That(IsTuringEquationTask.IsTuringEquation("10+20=30"), Is.EqualTo(true));
        Assert.That(IsTuringEquationTask.IsTuringEquation("0001000+000200=00030"), Is.EqualTo(true));
        Assert.That(IsTuringEquationTask.IsTuringEquation("1234+5=1239"), Is.EqualTo(false));
        Assert.That(IsTuringEquationTask.IsTuringEquation("1+0=0"), Is.EqualTo(false));
        Assert.That(IsTuringEquationTask.IsTuringEquation("7000+8000=51"), Is.EqualTo(true));
        Assert.That(IsTuringEquationTask.IsTuringEquation("0+0=0"), Is.EqualTo(true));
    }
}