namespace CodeWarsTest;
using CodeWars7kyu;

public class TIYFizzBuzzTest
{
    [Test]
    public void TIYFizzBuzz()
    {
        Assert.That(TIYFizzBuzzTask.FizzBuzz("H"), Is.EqualTo("Iron"));

        Assert.That(TIYFizzBuzzTask.FizzBuzz("e"), Is.EqualTo("Yard"));

        Assert.That(TIYFizzBuzzTask.FizzBuzz("l"), Is.EqualTo("l"));

        Assert.That(TIYFizzBuzzTask.FizzBuzz("O"), Is.EqualTo("Iron Yard"));

        Assert.That(TIYFizzBuzzTask.FizzBuzz("?"), Is.EqualTo("?"));

        Assert.That(TIYFizzBuzzTask.FizzBuzz("Hello WORLD!"), Is.EqualTo("IronYardllYard IronIron YardIronIronIron!"));
    }
}