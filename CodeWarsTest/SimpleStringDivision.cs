namespace CodeWarsTest;

using CodeWars7kyu;

public class SimpleStringDivision
{
    [Test]
    public void SimpleStringDivisionTest()
    {
        Assert.That(SimpleStringDivisionTask.Solve("123", 1), Is.EqualTo(23));
        Assert.That(SimpleStringDivisionTask.Solve("1234", 1), Is.EqualTo(234));     
        Assert.That(SimpleStringDivisionTask.Solve("1234", 2), Is.EqualTo(34));
        Assert.That(SimpleStringDivisionTask.Solve("1234", 3), Is.EqualTo(4)); 
   
    }
}