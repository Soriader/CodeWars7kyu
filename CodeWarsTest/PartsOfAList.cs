using CodeWars7kyu;

namespace CodeWarsTest;

public class PartsOfAList
{
    [Test]
    public static void PartsOfAListTest()
    {
        string[] s1 = new string[] { "cdIw", "tzIy", "xDu", "rThG" };
        string[][] expected = new string[][] 
        {
    
            new string[] { "cdIw", "tzIy xDu rThG" },
    
            new string[] { "cdIw tzIy", "xDu rThG" },
    
            new string[] { "cdIw tzIy xDu", "rThG" }

        };
        CollectionAssert.AreEqual(expected, PartsOfAListTask.Partlist(s1));
    }
}