namespace CodeWarsTest;

using CodeWars7kyu;

public class StonePickaxeCraftingTest
{
    [Test]
    public void StonePickaxeCrafting()
    {
        string[] stringToMinecraftArrayConverter(string s)
        {
            Dictionary<char, string> map = new Dictionary<char, string>()
            { {'S', "Sticks"} , {'s', "Stone"}, {'W', "Wood" }, {'w', "Wool" },
                {'C', "Cobblestone" }, {'D', "Dirt" }, {'d', "Diamond" } };
            return s.Select(x => map[x]).ToArray();
        }

        var arr = stringToMinecraftArrayConverter("");
        var actual = StonePickaxeCraftingTask.StonePick(arr);
        Assert.That(actual, Is.EqualTo(0));

        Assert.AreEqual(2, StonePickaxeCraftingTask.StonePick(stringToMinecraftArrayConverter("SSSSCCCCCC")));
        Assert.AreEqual(0, StonePickaxeCraftingTask.StonePick(stringToMinecraftArrayConverter("SSC")));
        Assert.AreEqual(0, StonePickaxeCraftingTask.StonePick(stringToMinecraftArrayConverter("SSSSwwwDDDDDD")));
        Assert.AreEqual(4, StonePickaxeCraftingTask.StonePick(stringToMinecraftArrayConverter("WWCCCCCCCCCCCC")));

    }

}