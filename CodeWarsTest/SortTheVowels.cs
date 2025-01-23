using CodeWars7kyu;

namespace CodeWarsTest;

public class SortTheVowels
{
    [Test]
    public void SortTheVowelsTest()
    {
        Assert.AreEqual("C|\n|o\nd|\n|e\nw|\n|a\nr|\ns|", SortTheVowelsTask.SortVowels("Codewars"),
            "Should return \"C|\n|o\nd|\n|e\nw|\n|a\nr|\ns|\" with \"Codewars\"");

        Assert.AreEqual("R|\nn|\nd|\n |\nT|\n|e\n5|\nT|", SortTheVowelsTask.SortVowels("Rnd Te5T"),
            "Should return \"R|\nn|\nd|\n |\nT|\n|e\n5|\nT|\" with \"Rnd Te5T\"");

        Assert.AreEqual("y|\n|o\n!|", SortTheVowelsTask.SortVowels("yo!"),
            "Should return \"y|\n|o\n!|\" with \"yo!\"");

        Assert.AreEqual("1|\n3|\n3|\n7|", SortTheVowelsTask.SortVowels("1337"),
            "Should return \"1|\n3|\n3|\n7|\" with \"1337\"");

        Assert.AreEqual("", SortTheVowelsTask.SortVowels(null), "Should return \"\" with null");
        Assert.AreEqual("", SortTheVowelsTask.SortVowels(""), "Should return \"\" with \"\"");

        Assert.AreEqual("|U\n|u\nY|\ny|\nM|\nm|\n1|", SortTheVowelsTask.SortVowels("UuYyMm1"),
            "Should return \"\" with \"|U\n|u\nY|\ny|\nM|\nm|\n1|\"");

        Assert.AreEqual("[|\n)|\n%|", SortTheVowelsTask.SortVowels("[)%"), "Should return \"\" with \"[|\n)|\n%|\"");

        Assert.AreEqual(
            "L|\n|O\nr|\n|E\nm|\n |\n|I\np|\ns|\n|U\nm|\n |\nd|\n|O\nl|\n|O\nr|\n |\ns|\n|I\nt|\n |\n|A\nm|\n|E\nt|",
            SortTheVowelsTask.SortVowels("LOrEm IpsUm dOlOr sIt AmEt"),
            "Should return \"L|\n|O\nr|\n|E\nm|\n |\n|I\np|\ns|\n|U\nm|\n |\nd|\n|O\nl|\n|O\nr|\n |\ns|\n|I\nt|\n |\n|A\nm|\n|E\nt|\" with \"LOrEm IpsUm dOlOr sIt AmEt\"");
    }
}