using CodeWars7kyu;

namespace CodeWarsTest;

public class OrderedCountOfCharacters
{
    [Test]
    public void OrderedCountOfCharactersTest()
    {
        var expected = new List<Tuple<char, int>>()
        {
            Tuple.Create('a', 5),
            Tuple.Create('b', 2),
            Tuple.Create('r', 2),
            Tuple.Create('c', 1),
            Tuple.Create('d', 1)
        };

        var result = OrderedCountOfCharactersTask.OrderedCount("abracadabra");

        CollectionAssert.AreEqual(expected, result);
    }
}