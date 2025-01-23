using CodeWars7kyu;

namespace CodeWarsTest;

public class HelpSuzukiCountHisVegetables
{
    [Test]
    public void HelpSuzukiCountHisVegetablesTest()
    {
        var grp1 = new Tuple<int, string>[]
        {
            new Tuple<int, string>(2, "tofu"),
            new Tuple<int, string>(2, "potato"),
            new Tuple<int, string>(2, "cucumber"),
            new Tuple<int, string>(2, "cabbage"),
            new Tuple<int, string>(1, "turnip"),
            new Tuple<int, string>(1, "pepper"),
            new Tuple<int, string>(1, "onion"),
            new Tuple<int, string>(1, "mushroom"),
            new Tuple<int, string>(1, "celery"),
            new Tuple<int, string>(1, "carrot")
        };

        var str1 = "potato tofu cucumber cabbage turnip pepper onion carrot celery mushroom potato tofu cucumber cabbage";

        var grp2 = new Tuple<int, string>[]
        {
            new Tuple<int, string>(15, "turnip"),
            new Tuple<int, string>(14, "mushroom"),
            new Tuple<int, string>(13, "cabbage"),
            new Tuple<int, string>(10, "carrot"),
            new Tuple<int, string>(9, "potato"),
            new Tuple<int, string>(7, "onion"),
            new Tuple<int, string>(6, "tofu"),
            new Tuple<int, string>(6, "pepper"),
            new Tuple<int, string>(5, "cucumber"),
            new Tuple<int, string>(4, "celery")
        };

        var str2 = "mushroom chopsticks chopsticks turnip mushroom carrot mushroom cabbage mushroom carrot tofu pepper cabbage " +
                   "potato cucumber mushroom mushroom potato turnip chopsticks cabbage celery celery turnip pepper chopsticks " +
                   "potato potato onion cabbage cucumber onion pepper onion cabbage potato tofu carrot cabbage cabbage turnip " +
                   "mushroom cabbage cabbage cucumber cabbage chopsticks turnip pepper onion pepper onion mushroom turnip carrot " +
                   "carrot tofu onion tofu chopsticks chopsticks chopsticks mushroom cucumber chopsticks carrot potato cabbage cabbage " +
                   "carrot mushroom chopsticks mushroom celery turnip onion carrot turnip cucumber carrot potato mushroom turnip " +
                   "mushroom cabbage tofu turnip turnip turnip mushroom tofu potato pepper turnip potato turnip celery carrot turnip";

        Assert.AreEqual(grp1, HelpSuzukiCountHisVegetablesTask.CountVegetables(str1));
        Assert.AreEqual(grp2, HelpSuzukiCountHisVegetablesTask.CountVegetables(str2));
    }
}