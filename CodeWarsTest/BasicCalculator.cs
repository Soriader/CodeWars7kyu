using CodeWars7kyu;

namespace CodeWarsTest;

public class BasicCalculator
{
    [Test]
    public void BasicCalculatorTest()
    {
        Assert.AreEqual(-4.8, BasicCalculatorTask.Execute(3.2, '-', 8));
        Assert.AreEqual(11.2, BasicCalculatorTask.Execute(3.2, '+', 8));
        Assert.AreEqual(0.4, BasicCalculatorTask.Execute(3.2, '/', 8));
        Assert.AreEqual(25.6, BasicCalculatorTask.Execute(3.2, '*', 8));
        Assert.Throws<ArgumentException>(() => BasicCalculatorTask.Execute(-3, 'w', 1));
    }
}