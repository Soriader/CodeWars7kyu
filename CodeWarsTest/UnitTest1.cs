using CodeWars7kyu;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Reflection;
using System.Text;
using static CodeWars7kyu.DisemvowelTrollsTask;

namespace CodeWarsTest
{
    public class Tests
    {

        [TestFixture]
        public class KataTest
        {
			public class Tests
            {
                [Test]
                public void SortArraysTest()
                {
                    Assert.AreEqual("one,three,two", string.Join(",", SortArraysTask.SortMe(new[] { "one", "two", "three" })));
                }

                [Test]
                public void BinaryOrHexTest()
                {
                    Assert.AreEqual("10", BinaryOrHexTask.EvensAndOdds(2));
                    Assert.AreEqual("d", BinaryOrHexTask.EvensAndOdds(13));
                    Assert.AreEqual("2f", BinaryOrHexTask.EvensAndOdds(47));
                    Assert.AreEqual("0", BinaryOrHexTask.EvensAndOdds(0));
                    Assert.AreEqual("11001000000000", BinaryOrHexTask.EvensAndOdds(12800));
                }

                [Test]
                public void FireonTheBoatTest()
                {
                    Assert.AreEqual("Boat Rudder Mast Boat Hull Water ~~ Boat Deck Hull ~~ Propeller Deck ~~ Deck Boat Mast", FireonTheBoatTask.FireFight("Boat Rudder Mast Boat Hull Water Fire Boat Deck Hull Fire Propeller Deck Fire Deck Boat Mast"));
                    Assert.AreEqual("Mast Deck Engine Water ~~", FireonTheBoatTask.FireFight("Mast Deck Engine Water Fire"));
                    Assert.AreEqual("~~ Deck Engine Sail Deck ~~ ~~ ~~ Rudder ~~ Boat ~~ ~~ Captain", FireonTheBoatTask.FireFight("Fire Deck Engine Sail Deck Fire Fire Fire Rudder Fire Boat Fire Fire Captain"));
                }

                [Test]
                public void ConsecutiveItemsTest()
                {
                    Assert.AreEqual(false, ConsecutiveItemsTask.Consecutive(new int[] { 1, 3, 5, 7 }, 3, 7));
                    Assert.AreEqual(true, ConsecutiveItemsTask.Consecutive(new int[] { 1, 3, 5, 7 }, 3, 1));
                    Assert.AreEqual(true, ConsecutiveItemsTask.Consecutive(new int[] { 1, 6, 9, -3, 4, -78, 0 }, -3, 4));
                }
                [Test]
                public void SevenAteNineTest()
                {
                    Assert.AreEqual("77", SevenAteNineTask.SevenAteNine("797"));
                    Assert.AreEqual("7777", SevenAteNineTask.SevenAteNine("7979797"));
                    Assert.AreEqual("16556178612178977", SevenAteNineTask.SevenAteNine("165561786121789797"));

                }

                [Test]
                public void ExampleTests()
                {
                    Assert.AreEqual("Escaped!", CatAndMouseTask.CatMouse("C....m"));
                    Assert.AreEqual("Caught!", CatAndMouseTask.CatMouse("C..m"));
                    Assert.AreEqual("Escaped!", CatAndMouseTask.CatMouse("C.....m"));
                }

                [Test]
                public void CompareStringsBySumOfCharsTest()
                {
                    Assert.AreEqual(true, CompareStringsBySumOfCharsTask.Compare("AD", "BC"));
                    Assert.AreEqual(false, CompareStringsBySumOfCharsTask.Compare("AD", "DD"));

                }

                [Test]
                public void CharCodeCalculationTest()
                {
                    Assert.AreEqual(0, CharCodeCalculationTask.Calc(""));
                    Assert.AreEqual(6, CharCodeCalculationTask.Calc("abc"));
                    Assert.AreEqual(6, CharCodeCalculationTask.Calc("ABC"));
                    Assert.AreEqual(6, CharCodeCalculationTask.Calc("abcdef"));
                    Assert.AreEqual(6, CharCodeCalculationTask.Calc("ifkhchlhfd"));
                    Assert.AreEqual(6, CharCodeCalculationTask.Calc("jfmgklf8hglbe"));
                    Assert.AreEqual(12, CharCodeCalculationTask.Calc("jaam"));
                    Assert.AreEqual(18, CharCodeCalculationTask.Calc("AFHJD"));
                    Assert.AreEqual(18, CharCodeCalculationTask.Calc("CodeWars"));
                    Assert.AreEqual(24, CharCodeCalculationTask.Calc("FVJFVDF"));
                    Assert.AreEqual(24, CharCodeCalculationTask.Calc("AOUCUAOF"));
                    Assert.AreEqual(30, CharCodeCalculationTask.Calc("aaaaaddddr"));
                    Assert.AreEqual(36, CharCodeCalculationTask.Calc("XLdNDcAbUkMnkV"));
                    Assert.AreEqual(42, CharCodeCalculationTask.Calc("cSuLifxDQkOiypJsxOJSE"));
                    Assert.AreEqual(48, CharCodeCalculationTask.Calc("ZHAUnSGoIbgPSezhjePIbHFrHUOv"));
                    Assert.AreEqual(54, CharCodeCalculationTask.Calc("VFhSMbZETZVHxYiiYsBMrWuecDN"));
                    Assert.AreEqual(60, CharCodeCalculationTask.Calc("sphPoGbicTCLbiuUcwFMEGaFmy"));
                    Assert.AreEqual(72, CharCodeCalculationTask.Calc("oXoQKiCflHIHFyGizCYCuaHhX"));
                    Assert.AreEqual(84, CharCodeCalculationTask.Calc("sUuPmNnnJOOCAGOuyzmcHQGJhXHYgZLY"));
                }

                [Test]
                public void FindCountofMostFrequentItemInAnArrayTest()
                {
                    Assert.AreEqual(5, FindCountofMostFrequentItemInAnArrayTask.MostFrequentItemCount(new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 }));
                }

                [Test]
                public void PaddedNumbersTest()
                {
                    Assert.AreEqual("Value is 00005", PaddedNumbersTask.Solution(5));
                }

                [Test]
                public void UniqueStringCharactersTest()
                {
                    Assert.That(UniqueStringCharactersTask.Solve("xyab", "xzca"), Is.EqualTo("ybzc"));
                    Assert.That(UniqueStringCharactersTask.Solve("xyabb", "xzca"), Is.EqualTo("ybbzc"));
                    Assert.That(UniqueStringCharactersTask.Solve("abcd", "xyz"), Is.EqualTo("abcdxyz"));
                    Assert.That(UniqueStringCharactersTask.Solve("xxx", "xzca"), Is.EqualTo("zca"));
                }

                [Test]
                public void NumberOfOccurrencesTest()
                {
                    Assert.AreEqual(2, NumberOfOccurrencesTask.NumberOfOccurrences(4, new int[] { 4, 0, 4 }));
                    Assert.AreEqual(0, NumberOfOccurrencesTask.NumberOfOccurrences(1, new int[] { 4, 0, 4 }));
                    Assert.AreEqual(1, NumberOfOccurrencesTask.NumberOfOccurrences(0, new int[] { 4, 0, 4 }));
                }

                [Test]
                public void SpecialNumberFiveTest()
                {
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00002), Is.EqualTo("Special!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00003), Is.EqualTo("Special!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00011), Is.EqualTo("Special!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00055), Is.EqualTo("Special!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(25432), Is.EqualTo("Special!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(02783), Is.EqualTo("NOT!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00006), Is.EqualTo("NOT!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00009), Is.EqualTo("NOT!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00026), Is.EqualTo("NOT!!"));
                }

                [Test]
                public void SumOfIntegersInStringTest()
                {
                    Assert.AreEqual(16, SumOfIntegersInStringTask.SumOfIntegersInString("12.4"));
                    Assert.AreEqual(3, SumOfIntegersInStringTask.SumOfIntegersInString("h3ll0w0rld"));
                    Assert.AreEqual(1, SumOfIntegersInStringTask.SumOfIntegersInString("Our company made approximately 1 million in gross revenue last quarter."));
                    Assert.AreEqual(18, SumOfIntegersInStringTask.SumOfIntegersInString("C4t5 are 4m4z1ng."));
                    Assert.AreEqual(3635, SumOfIntegersInStringTask.SumOfIntegersInString("The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog"));
                }

                [Test]
                public void AlternateCaseTest()
                {
                    Assert.AreEqual("ABC", AlternateCaseTask.AlternateCase("abc"));
                    Assert.AreEqual("abc", AlternateCaseTask.AlternateCase("ABC"));
                    Assert.AreEqual("hELLO wORLD", AlternateCaseTask.AlternateCase("Hello World"));
                }

                [Test]
                public void ARuleOfDivisibilityBySevenTest()
                {
                    Assert.AreEqual(new long[] { 10, 2 }, ARuleOfDivisibilityBySevenTask.Seven(1021));
                    Assert.AreEqual(new long[] { 7, 2 }, ARuleOfDivisibilityBySevenTask.Seven(1603));
                    Assert.AreEqual(new long[] { 35, 1 }, ARuleOfDivisibilityBySevenTask.Seven(371));
                    Assert.AreEqual(new long[] { 42, 1 }, ARuleOfDivisibilityBySevenTask.Seven(483));
                }

                [Test]
                public void ReturnTheFirstMMultiplesOfNTest()
                {
                    Assert.AreEqual(new double[] { 5, 10, 15 }, ReturnTheFirstMMultiplesOfNTask.Multiples(3, 5));
                }

                [Test]
                public void ToLeetSpeakTest()
                {
                    Assert.AreEqual("1337", ToLeetSpeakTask.ToLeetSpeak("LEET"));
                    Assert.AreEqual("(0D3W@R$", ToLeetSpeakTask.ToLeetSpeak("CODEWARS"));
                    Assert.AreEqual("#3110 W0R1D", ToLeetSpeakTask.ToLeetSpeak("HELLO WORLD"));
                    Assert.AreEqual("10R3M !P$UM D010R $!7 @M37", ToLeetSpeakTask.ToLeetSpeak("LOREM IPSUM DOLOR SIT AMET"));
                    Assert.AreEqual("7#3 QU!(K 8R0WN F0X JUMP$ 0V3R 7#3 1@2Y D06", ToLeetSpeakTask.ToLeetSpeak("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"));
                }

                [Test]
                public void BuildingBlocksTest()
                {
                    BuildingBlocksTask b = new BuildingBlocksTask(new int[] { 2, 2, 2 });
                    Assert.AreEqual(2, b.GetWidth());
                    Assert.AreEqual(2, b.GetLength());
                    Assert.AreEqual(2, b.GetHeight());
                    Assert.AreEqual(8, b.GetVolume());
                    Assert.AreEqual(24, b.GetSurfaceArea());
                }

                [Test]
                public void DifferenceOfSquaresTest()
                {
                    Assert.AreEqual(170, DifferenceOfSquaresTask.DifferenceOfSquares(5));
                    Assert.AreEqual(2640, DifferenceOfSquaresTask.DifferenceOfSquares(10));
                    Assert.AreEqual(25164150, DifferenceOfSquaresTask.DifferenceOfSquares(100));
                }

                [Test]
                public void LastSurvivorTest()
                {
                    {
                        string letters = "abc";
                        int[] coords = { 1, 1 };
                        string expected = "a";
                        string actual = LastSurvivorTask.LastSurvivor(letters, coords);
                        Assert.AreEqual(expected, actual);
                    }

                    {
                        string letters = "kbc";
                        int[] coords = { 0, 1 };
                        string expected = "b";
                        string actual = LastSurvivorTask.LastSurvivor(letters, coords);
                        Assert.AreEqual(expected, actual);
                    }

                    {
                        string letters = "zbk";
                        int[] coords = { 2, 1 };
                        string expected = "z";
                        string actual = LastSurvivorTask.LastSurvivor(letters, coords);
                        Assert.AreEqual(expected, actual);
                    }

                    {
                        string letters = "c";
                        int[] coords = { };
                        string expected = "c";
                        string actual = LastSurvivorTask.LastSurvivor(letters, coords);
                        Assert.AreEqual(expected, actual);
                    }

                    {
                        string letters = "foiflxtpicahhkqjswjuyhmypkrdbwnmwbrrvdycqespfvdviucjoyvskltqaqirtjqulprjjoaiagobpftywabqjdmiofpsr";
                        int[] coords = { 8, 59, 52, 93, 21, 40, 88, 85, 59, 10, 82, 18, 74, 59, 51, 47, 75, 49, 23, 56, 1, 33, 39, 33, 34, 44, 25, 0, 51, 25, 36, 32, 57, 10, 57, 12, 51, 55, 24, 55, 31, 49, 6, 15, 10, 48, 27, 29, 38, 30, 35, 42, 23, 32, 9, 39, 39, 36, 8, 29, 2, 33, 14, 3, 13, 25, 9, 25, 18, 10, 1, 2, 20, 8, 2, 11, 5, 7, 0, 10, 10, 8, 12, 3, 5, 1, 7, 7, 5, 1, 4, 0, 4, 0, 0, 1 };
                        string expected = "d";
                        string actual = LastSurvivorTask.LastSurvivor(letters, coords);
                        Assert.AreEqual(expected, actual);
                    }
                }


                [Test]
                public void FindTheVowelsTest()
                {
                    Assert.AreEqual(new int[] { }, FindTheVowelsTask.VowelIndices("mmm"));
                    Assert.AreEqual(new int[] { 1, 5 }, FindTheVowelsTask.VowelIndices("apple"));
                    Assert.AreEqual(new int[] { 2, 4 }, FindTheVowelsTask.VowelIndices("super"));
                    Assert.AreEqual(new int[] { 1, 3, 6 }, FindTheVowelsTask.VowelIndices("orange"));
                    Assert.AreEqual(new int[] { 2, 4, 7, 9, 12, 14, 16, 19, 21, 24, 25, 27, 29, 31, 32, 33 }, FindTheVowelsTask.VowelIndices("supercalifragilisticexpialidocious"));
                }

                [Test]
                public void SplitInPartsTest()
                {
                    string str = "HelloKata";
                    Assert.AreEqual("HelloKata", SplitInPartsTask.SplitInParts(str, 9));

                    string str1 = "HelloKata";
                    Assert.AreEqual("H e l l o K a t a", SplitInPartsTask.SplitInParts(str1, 1));
                }

                [Test]
                public void LongestVowelChainTest()
                {
                    Assert.AreEqual(2, LongestVowelChainTask.Solve("codewarriors"));
                    Assert.AreEqual(3, LongestVowelChainTask.Solve("suoidea"));
                    Assert.AreEqual(3, LongestVowelChainTask.Solve("ultrarevolutionariees"));
                    Assert.AreEqual(1, LongestVowelChainTask.Solve("strengthlessnesses"));
                    Assert.AreEqual(2, LongestVowelChainTask.Solve("cuboideonavicuare"));
                    Assert.AreEqual(5, LongestVowelChainTask.Solve("chrononhotonthuooaos"));
                    Assert.AreEqual(8, LongestVowelChainTask.Solve("iiihoovaeaaaoougjyaw"));
                }

                [Test]
                public void NumbersToLettersTest()
                {
                    string expected1 = "codewars";

                    string actual1 = NumbersToLettersTask.Switcher(new string[] { "24", "12", "23", "22", "4", "26", "9", "8" });

                    Assert.AreEqual(expected1, actual1);

                    string expected2 = "btswmdsbd kkw";

                    string actual2 = NumbersToLettersTask.Switcher(new string[] { "25", "7", "8", "4", "14", "23", "8", "25", "23", "29", "16", "16", "4" });

                    Assert.AreEqual(expected2, actual2);

                    string expected3 = "wc";

                    string actual3 = NumbersToLettersTask.Switcher(new string[] { "4", "24" });

                    Assert.AreEqual(expected3, actual3);
                }

                [Test]
                public void SmallestValueOfAnArrayTest()
                {
                    Assert.AreEqual(1, SmallestValueOfAnArrayTask.FindSmallest(new int[] { 5, 4, 3, 2, 1 }, "value"));
                    Assert.AreEqual(4, SmallestValueOfAnArrayTask.FindSmallest(new int[] { 5, 4, 3, 2, 1 }, "index"));
                }

                [Test]
                public void LargestElementsTest()
                {
                    Assert.AreEqual(new List<int> { 9, 10 }, LargestElementsTask.Largest(2, new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }));
                    Assert.AreEqual(new List<int> { 5, 5, 5 }, LargestElementsTask.Largest(3, new List<int> { 5, 1, 5, 2, 3, 1, 2, 3, 5 }));
                    Assert.AreEqual(new List<int> { 3, 5, 9, 13, 22, 50, 63 }, LargestElementsTask.Largest(7, new List<int> { 9, 1, 50, 22, 3, 13, 2, 63, 5 }));
                    Assert.AreEqual(new List<int> { }, LargestElementsTask.Largest(0, new List<int> { 1, 2, 3, 4, 8, 7, 6, 5 }));
                }

                [Test]
                public void NthSmallestElementTest()
                {
                    Assert.AreEqual(2, NthSmallestElementTask.NthSmallest(new int[] { 3, 1, 2 }, 2));
                    Assert.AreEqual(7, NthSmallestElementTask.NthSmallest(new int[] { 15, 20, 7, 10, 4, 3 }, 3));
                    Assert.AreEqual(2, NthSmallestElementTask.NthSmallest(new int[] { 2, 169, 13, -5, 0, -1 }, 4));
                    Assert.AreEqual(2, NthSmallestElementTask.NthSmallest(new int[] { 2, 1, 3, 3, 1, 2 }, 3));
                }

                [Test]
                public void TheOldSwitcheroTest()
                {
                    Assert.AreEqual("th3s 6s my str15ng", TheOldSwitcheroTask.Vowel2Index("this is my string"));
                    Assert.AreEqual("C2d4w6rs 10s th15 b18st s23t25 27n th32 w35rld", TheOldSwitcheroTask.Vowel2Index("Codewars is the best site in the world"));
                    Assert.AreEqual("T2m4rr7w 10s g1415ng t20 b23 r2627n29ng", TheOldSwitcheroTask.Vowel2Index("Tomorrow is going to be raining"));
                }

                [Test]
                public void LoveVsFriendshipTest()
                {
                    Assert.AreEqual(100, LoveVsFriendshipTask.WordsToMarks("attitude"));
                    Assert.AreEqual(75, LoveVsFriendshipTask.WordsToMarks("friends"));
                    Assert.AreEqual(66, LoveVsFriendshipTask.WordsToMarks("family"));
                    Assert.AreEqual(96, LoveVsFriendshipTask.WordsToMarks("knowledge"));

                }

                [Test]
                public void FindTheNthDigitOfANumberTest()
                {
                    Assert.AreEqual(5, FindTheNthDigitOfANumberTask.FindDigit(5673, 4));
                    Assert.AreEqual(2, FindTheNthDigitOfANumberTask.FindDigit(129, 2));
                    Assert.AreEqual(8, FindTheNthDigitOfANumberTask.FindDigit(-2825, 3));
                    Assert.AreEqual(0, FindTheNthDigitOfANumberTask.FindDigit(-456, 4));
                    Assert.AreEqual(0, FindTheNthDigitOfANumberTask.FindDigit(0, 20));
                    Assert.AreEqual(-1, FindTheNthDigitOfANumberTask.FindDigit(65, 0));
                    Assert.AreEqual(-1, FindTheNthDigitOfANumberTask.FindDigit(24, -8));
                }

                [Test]
                public void WordValuesTest()
                {
                    Assert.AreEqual(new int[] { 88, 12, 225 }, WordValuesTask.WordValue(new string[] { "codewars", "abc", "xyz" }));
                    Assert.AreEqual(new int[] { 12, 24, 18, 24 }, WordValuesTask.WordValue(new string[] { "abc abc", "abc abc", "abc", "abc" }));

                }

                [Test]
                public void UnluckyDaysTest()
                {
                    Assert.AreEqual(1, UnluckyDaysTask.UnluckyDays(1586));
                    Assert.AreEqual(3, UnluckyDaysTask.UnluckyDays(1001));
                    Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(2819));
                    Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(2792));
                    Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(2723));
                    Assert.AreEqual(1, UnluckyDaysTask.UnluckyDays(1909));
                    Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(1812));
                    Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(1618));
                    Assert.AreEqual(1, UnluckyDaysTask.UnluckyDays(2132));
                    Assert.AreEqual(3, UnluckyDaysTask.UnluckyDays(2065));
                }

                [Test]
                public void AutomorphicNumberTest()
                {
                    Assert.AreEqual("Automorphic", AutomorphicNumberTask.Automorphic(1));
                    Assert.AreEqual("Automorphic", AutomorphicNumberTask.Automorphic(6));
                    Assert.AreEqual("Automorphic", AutomorphicNumberTask.Automorphic(625));
                    Assert.AreEqual("Not!!", AutomorphicNumberTask.Automorphic(3));
                    Assert.AreEqual("Not!!", AutomorphicNumberTask.Automorphic(95));
                    Assert.AreEqual("Not!!", AutomorphicNumberTask.Automorphic(225));
                }


                [Test]
                public void RemoveAllTheMarkedElementsOfAListTest()
                {

                    CollectionAssert.AreEqual(new int[] { 2, 2, 4 }, RemoveAllTheMarkedElementsOfAListTask.Remove(new int[] { 1, 1, 2, 3, 1, 2, 3, 4 }, new int[] { 1, 3 }));
                    CollectionAssert.AreEqual(new int[] { 5, 6, 7, 8 }, RemoveAllTheMarkedElementsOfAListTask.Remove(new int[] { 1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8 }, new int[] { 1, 3, 4, 2 }));

                }

                [Test]
                public void TheOfficeIIBoredomScoreTest()
                {
                    Assert.AreEqual("kill me now", TheOfficeIIBoredomScoreTask.Boredom(new Dictionary<string, string>() { { "Tim", "accounts" }, { "Jim", "trading" }, { "Sandy", "regulation" }, { "Andy", "accounts" }, { "Katie", "finance" }, { "Laura", "IS" } }));
                    Assert.AreEqual("i can handle this", TheOfficeIIBoredomScoreTask.Boredom(new Dictionary<string, string>() { { "Jim", "pissing about" }, { "Tim", "regulation" }, { "Andy", "IS" }, { "Laura", "pissing about" }, { "Alex", "canteen" }, { "John", "canteen" } }));
                    Assert.AreEqual("party time!!", TheOfficeIIBoredomScoreTask.Boredom(new Dictionary<string, string>() { { "Andy", "pissing about" }, { "Tim", "accounts" }, { "Smith", "pissing about" }, { "Randy", "pissing about" }, { "Sandy", "IS" }, { "Laura", "pissing about" } }));
                }

                [Test]
                public void IndexedCapitalizationTest()
                {
                    Assert.AreEqual("aBCdeF", IndexedCapitalizationTask.Capitalize("abcdef", new List<int> { 1, 2, 5 }));
                    Assert.AreEqual("aBCdeF", IndexedCapitalizationTask.Capitalize("abcdef", new List<int> { 1, 2, 5, 100 }));
                    Assert.AreEqual("aBCdeF", IndexedCapitalizationTask.Capitalize("abcdef", new List<int> { 1, 100, 2, 5 }));
                    Assert.AreEqual("cOdEwArs", IndexedCapitalizationTask.Capitalize("codewars", new List<int> { 1, 3, 5, 50 }));
                    Assert.AreEqual("abRacaDabRA", IndexedCapitalizationTask.Capitalize("abracadabra", new List<int> { 2, 6, 9, 10 }));
                    Assert.AreEqual("codewArriors", IndexedCapitalizationTask.Capitalize("codewarriors", new List<int> { 5 }));
                    Assert.AreEqual("Indexinglessons", IndexedCapitalizationTask.Capitalize("indexinglessons", new List<int> { 0 }));
                }


                [Test]
                public void DigitalCypherTest()
                {
                    Assert.AreEqual(new int[] { 20, 12, 18, 30, 21 }, DigitalCypherTask.Encode("scout", 1939));
                    Assert.AreEqual(new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, DigitalCypherTask.Encode("masterpiece", 1939));

                }

                [Test]
                public static void GoingToTheCinemaTest()
                {
                    Assert.AreEqual(43, GoingToTheCinemaTask.Movie(500, 15, 0.9));
                    Assert.AreEqual(24, GoingToTheCinemaTask.Movie(100, 10, 0.95));

                }

                [Test]
                public void DisariumNumberTest()
                {
                    Assert.AreEqual("Disarium !!", DisariumNumberTask.DisariumNumber(89));
                    Assert.AreEqual("Not !!", DisariumNumberTask.DisariumNumber(564));
                    Assert.AreEqual("Disarium !!", DisariumNumberTask.DisariumNumber(135));
                    Assert.AreEqual("Not !!", DisariumNumberTask.DisariumNumber(136586));

                }

                [Test]
                public void CurryingFunctionsMultiplyAllElementsInAnArrayTest()
                {
                    Assert.AreEqual(new int[] { 1, 2, 3 }, CurryingFunctionsMultiplyAllElementsInAnArrayTask.MultiplyAll(new int[] { 1, 2, 3 })(1));
                    Assert.AreEqual(new int[] { 2, 4, 6 }, CurryingFunctionsMultiplyAllElementsInAnArrayTask.MultiplyAll(new int[] { 1, 2, 3 })(2));
                    Assert.AreEqual(new int[] { 0, 0, 0 }, CurryingFunctionsMultiplyAllElementsInAnArrayTask.MultiplyAll(new int[] { 1, 2, 3 })(0));
                    Assert.AreEqual(new int[] { }, CurryingFunctionsMultiplyAllElementsInAnArrayTask.MultiplyAll(new int[] { })(10));

                }

                [Test]
                public void FoldingYourWayToTheMoonTest()
                {
                    Assert.AreEqual(42, FoldingYourWayToTheMoonTask.FoldTo(384000000));
                }


                [Test]
                public void FunctionalAdditionTest()
                {
                    Assert.AreEqual(4, FunctionalAdditionTask.Add(1)(3));
                }

                [Test]
                public void DigitsExplosionTest()
                {
                    Assert.AreEqual("333122", DigitsExplosionTask.Explode("312"));
                    Assert.AreEqual("12222666666999999999", DigitsExplosionTask.Explode("102269"));
                }

                [Test]
                public void IncrementerTest()
                {
                    Assert.AreEqual(new int[] { 2, 4, 6 }, IncrementerTask.Incrementer(new int[] { 1, 2, 3 }));
                    Assert.AreEqual(new int[0], IncrementerTask.Incrementer(new int[0]));
                    Assert.AreEqual(new int[] { 5, 8, 0, 5, 8 }, IncrementerTask.Incrementer(new int[] { 4, 6, 7, 1, 3 }));
                    Assert.AreEqual(new int[] { 2, 4, 6, 8, 0, 2, 4, 6, 8, 9, 0, 1, 2, 2 }, IncrementerTask.Incrementer(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 9, 8 }));
                }

                [Test]
                public void SortByLastCharTest()
                {
                    Assert.AreEqual(new[] { "cba", "cab", "abc" }, SortByLastCharTask.Last("abc cba cab"));
                    Assert.AreEqual(new[] { "aaa", "bbb", "ccc", "ddd" }, SortByLastCharTask.Last("bbb ccc aaa ddd"));
                    Assert.AreEqual(new[] { "wa", "de", "co", "rs" }, SortByLastCharTask.Last("co de wa rs"));
                    Assert.AreEqual(new[] { "axa", "ava", "asa" }, SortByLastCharTask.Last("axa ava asa"));

                    Assert.AreEqual(new[] { "a", "need", "ubud", "i", "taxi", "man", "to", "up" },
                        SortByLastCharTask.Last("man i need a taxi up to ubud"));

                    Assert.AreEqual(new[] { "time", "are", "we", "the", "climbing", "volcano", "up", "what" },
                        SortByLastCharTask.Last("what time are we climbing up the volcano"));

                    Assert.AreEqual(new[] { "take", "me", "semynak", "to" }, SortByLastCharTask.Last("take me to semynak"));

                    Assert.AreEqual(new[] { "massage", "massage", "massage", "yes", "yes" },
                        SortByLastCharTask.Last("massage yes massage yes massage"));

                    Assert.AreEqual(new[] { "a", "and", "take", "dance", "please", "bintang" },
                        SortByLastCharTask.Last("take bintang and a dance please"));
                }

                [Test]
                public void HelpSuzukiRakeHisGardenTest()
                {
                    var garden1 = "slug spider rock gravel gravel gravel gravel gravel gravel gravel";
                    var expectedGarden1 = "gravel gravel rock gravel gravel gravel gravel gravel gravel gravel";
                    Assert.AreEqual(expectedGarden1, HelpSuzukiRakeHisGardenTask.RakeGarden(garden1));

                    var garden2 = "gravel gravel gravel gravel gravel gravel gravel gravel gravel rock slug ant gravel gravel snail rock gravel gravel gravel gravel gravel gravel gravel slug gravel ant gravel gravel gravel gravel rock slug gravel gravel gravel gravel gravel snail gravel gravel rock gravel snail slug gravel gravel spider gravel gravel gravel gravel gravel gravel gravel gravel moss gravel gravel gravel snail gravel gravel gravel ant gravel gravel moss gravel gravel gravel gravel snail gravel gravel gravel gravel slug gravel rock gravel gravel rock gravel gravel gravel gravel snail gravel gravel rock gravel gravel gravel gravel gravel spider gravel rock gravel gravel";
                    var expectedGarden2 = "gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel rock gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel rock gravel gravel";
                    Assert.AreEqual(expectedGarden2, HelpSuzukiRakeHisGardenTask.RakeGarden(garden2));
                }

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

                [Test]
                public void RotateForAMaxTest()
                {
                    Assert.AreEqual(85821534, RotateForAMaxTask.MaxRot(38458215));
                    Assert.AreEqual(988103115, RotateForAMaxTask.MaxRot(195881031));
                    Assert.AreEqual(962193428, RotateForAMaxTask.MaxRot(896219342));
                    Assert.AreEqual(85821534, RotateForAMaxTask.MaxRot(38458215));
                }

                [Test]
                public void MaximumTripletSumTest()
                {
                    Assert.AreEqual(0, MaximumTripletSumTask.MaxTriSum(new int[] { -2, 0, 2 }));
                    Assert.AreEqual(17, MaximumTripletSumTask.MaxTriSum(new int[] { 3, 2, 6, 8, 2, 3 }));
                    Assert.AreEqual(-9, MaximumTripletSumTask.MaxTriSum(new int[] { -3, -27, -4, -2, -27, -2 }));
                    Assert.AreEqual(232, MaximumTripletSumTask.MaxTriSum(new int[] { -13, -50, 57, 13, 67, -13, 57, 108, 67 }));

                }

                [Test]
                public void SortOutTheMenFromBoysTest()
                {
                    Assert.AreEqual(new int[] { 14, 17, 7, 3 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 7, 3, 14, 17 }));
                    Assert.AreEqual(new int[] { 2, 90, 95, 43, 37 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 2, 43, 95, 90, 37 }));
                    Assert.AreEqual(new int[] { 20, 34, 46, 50, 43, 33 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 20, 33, 50, 34, 43, 46 }));
                    Assert.AreEqual(new int[] { 72, 76, 82, 100, 91, 85 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 82, 91, 72, 76, 76, 100, 85 }));
                    Assert.AreEqual(new int[] { 2, 10, 17, 15, 1 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 2, 15, 17, 15, 2, 10, 10, 17, 1, 1 }));
                    Assert.AreEqual(new int[] { -32, -35, -39, -41 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { -32, -39, -35, -41 }));
                    Assert.AreEqual(new int[] { -66, -64, -63, -65, -71 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { -64, -71, -63, -66, -65 }));
                    Assert.AreEqual(new int[] { -100, -96, -94, -99 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { -94, -99, -100, -99, -96, -99 }));
                    Assert.AreEqual(new int[] { -26, -14, -27, -49, -51, -53 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { -53, -26, -53, -27, -49, -51, -14 }));
                    Assert.AreEqual(new int[] { -86, -56, -30, -15, -17, -33, -45, -85 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { -17, -45, -15, -33, -85, -56, -86, -30 }));
                    Assert.AreEqual(new int[] { -78, -38, 12, 89 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 12, 89, -38, -78 }));
                    Assert.AreEqual(new int[] { -90, 2, 95, 37, -43 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 2, -43, 95, -90, 37 }));
                    Assert.AreEqual(new int[] { -12, 82, 21, 1, -61, -87 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 82, -61, -87, -12, 21, 1 }));
                    Assert.AreEqual(new int[] { -28, 2, 76, 88, 63, -57, -85 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 63, -57, 76, -85, 88, 2, -28 }));
                    Assert.AreEqual(new int[] { -282, 818, 900, 928, 281, 49, -1 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 49, 818, -282, 900, 928, 281, -282, -1 }));
                }

                [Test]
                public void OddEvenStringSortTest()
                {
                    Assert.AreEqual("CdWr oeas", OddEvenStringSortTask.SortMyString("CodeWars"));

                }

                [Test]
                public void TidyNumberTest()
                {
                    Assert.AreEqual(false, TidyNumberTask.TidyNumber(102));
                    Assert.AreEqual(false, TidyNumberTask.TidyNumber(9672));
                    Assert.AreEqual(true, TidyNumberTask.TidyNumber(12));
                    Assert.AreEqual(true, TidyNumberTask.TidyNumber(2789));

                }

                [Test]
                public void SimpleStringCharactersTest()
                {
                    Assert.AreEqual(new int[] { 1, 18, 3, 2 }, SimpleStringCharactersTask.Solve("Codewars@codewars123.com"));
                    Assert.AreEqual(new int[] { 7, 6, 3, 2 }, SimpleStringCharactersTask.Solve("bgA5<1d-tOwUZTS8yQ"));
                    Assert.AreEqual(new int[] { 9, 9, 6, 9 }, SimpleStringCharactersTask.Solve("P*K4%>mQUDaG$h=cx2?.Czt7!Zn16p@5H"));
                    Assert.AreEqual(new int[] { 15, 8, 6, 9 }, SimpleStringCharactersTask.Solve("RYT'>s&gO-.CM9AKeH?,5317tWGpS<*x2ukXZD"));
                }

                [Test]
                public void SumOfOddCubedNumbersTest()
                {
                    Assert.AreEqual(28, SumOfOddCubedNumbersTask.CubeOdd(new int[] { 1, 2, 3, 4 }));
                    Assert.AreEqual(0, SumOfOddCubedNumbersTask.CubeOdd(new int[] { -3, -2, 2, 3 }));
                }

                [Test]
                public void NBalancedNumberTest()
                {
                    Assert.AreEqual("Not Balanced", BalancedNumberTask.BalancedNumber(1024));
                    Assert.AreEqual("Not Balanced", BalancedNumberTask.BalancedNumber(66545));
                    Assert.AreEqual("Not Balanced", BalancedNumberTask.BalancedNumber(295591));
                    Assert.AreEqual("Not Balanced", BalancedNumberTask.BalancedNumber(1230987));
                    Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(7));
                    Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(959));
                    Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(13));
                    Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(424));
                    Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(56239814));
                }

                [Test]
                public void SumOfCubesTest()
                {
                    Assert.AreEqual(1, SumOfCubesTask.SumCubes(1));
                    Assert.AreEqual(9, SumOfCubesTask.SumCubes(2));
                    Assert.AreEqual(36, SumOfCubesTask.SumCubes(3));
                    Assert.AreEqual(100, SumOfCubesTask.SumCubes(4));
                    Assert.AreEqual(3025, SumOfCubesTask.SumCubes(10));
                    Assert.AreEqual(58155876, SumOfCubesTask.SumCubes(123));
                }

                [Test]
                public void FindTheMiddleElementTest()
                {
                    Assert.AreEqual(0, FindTheMiddleElementTask.Gimme(new double[] { 2, 3, 1 }));
                    Assert.AreEqual(1, FindTheMiddleElementTask.Gimme(new double[] { 5, 10, 14 }));
                }

                [Test]
                public void SortTheGiftCodeTest()
                {
                    Assert.AreEqual("abcdef", SortTheGiftCodeTask.SortGiftCode("abcdef"));
                    Assert.AreEqual("kpqsuvy", SortTheGiftCodeTask.SortGiftCode("pqksuvy"));
                    Assert.AreEqual("abcdefghijklmnopqrstuvwxyz", SortTheGiftCodeTask.SortGiftCode("zyxwvutsrqponmlkjihgfedcba"));
                }

                [Test]
                public void AlphabetSymmetryTest()
                {
                    Assert.That(AlphabetSymmetryTask.Solve(new List<string> { "abode", "ABc", "xyzD" }), Is.EqualTo(new List<int> { 4, 3, 1 }));
                    Assert.That(AlphabetSymmetryTask.Solve(new List<string> { "abide", "ABc", "xyz" }), Is.EqualTo(new List<int> { 4, 3, 0 }));
                    Assert.That(AlphabetSymmetryTask.Solve(new List<string> { "IAMDEFANDJKL", "thedefgh", "xyzDEFghijabc" }), Is.EqualTo(new List<int> { 6, 5, 7 }));
                    Assert.That(AlphabetSymmetryTask.Solve(new List<string> { "encode", "abc", "xyzD", "ABmD" }), Is.EqualTo(new List<int> { 1, 3, 1, 3 }));
                }

                [Test]
                public void OverTheRoadTest()
                {
                    Assert.AreEqual(6, OverTheRoadTask.OverTheRoad(1, 3));
                    Assert.AreEqual(4, OverTheRoadTask.OverTheRoad(3, 3));
                    Assert.AreEqual(5, OverTheRoadTask.OverTheRoad(2, 3));
                    Assert.AreEqual(8, OverTheRoadTask.OverTheRoad(3, 5));
                    Assert.AreEqual(16, OverTheRoadTask.OverTheRoad(7, 11));
                }

                [Test]
                public void DivideAndConquerTest()
                {
                    Assert.AreEqual(2, DivideAndConquerTask.DivCon(new object[] { 9, 3, "7", "3" }));
                    Assert.AreEqual(14, DivideAndConquerTask.DivCon(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
                    Assert.AreEqual(13, DivideAndConquerTask.DivCon(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
                    Assert.AreEqual(11, DivideAndConquerTask.DivCon(new object[] { "1", "5", "8", 8, 9, 9, 2, "3" }));
                    Assert.AreEqual(61, DivideAndConquerTask.DivCon(new object[] { 8, 0, 0, 8, 5, 7, 2, 3, 7, 8, 6, 7 }));
                    Assert.AreEqual(-6, DivideAndConquerTask.DivCon(new object[] { "0", "1", "2", "3" }));
                    Assert.AreEqual(6, DivideAndConquerTask.DivCon(new object[] { 0, 1, 2, 3 }));
                    Assert.AreEqual(0, DivideAndConquerTask.DivCon(new object[] { 1, "1" }));
                    Assert.AreEqual(-2, DivideAndConquerTask.DivCon(new object[] { -1, "1" }));
                    Assert.AreEqual(2, DivideAndConquerTask.DivCon(new object[] { 1, "-1" }));
                    Assert.AreEqual(1, DivideAndConquerTask.DivCon(new object[] { 1 }));
                    Assert.AreEqual(-1, DivideAndConquerTask.DivCon(new object[] { "1" }));
                    Assert.AreEqual(0, DivideAndConquerTask.DivCon(new object[] { }));
                }

                [Test]
                public void MakeAFunctionThatDoesArithmeticTest()
                {
                    Assert.AreEqual(3, MakeAFunctionThatDoesArithmeticTask.Arithmetic(1, 2, "add"));
                    Assert.AreEqual(6, MakeAFunctionThatDoesArithmeticTask.Arithmetic(8, 2, "subtract"));
                    Assert.AreEqual(10, MakeAFunctionThatDoesArithmeticTask.Arithmetic(5, 2, "multiply"));
                    Assert.AreEqual(4, MakeAFunctionThatDoesArithmeticTask.Arithmetic(8, 2, "divide"));
                }

                [Test]
                public void MinimizeSumOfArrayTest()
                {
                    Assert.AreEqual(342, MinimizeSumOfArrayTask.MinSum(new int[] { 12, 6, 10, 26, 3, 24 }));
                    Assert.AreEqual(74, MinimizeSumOfArrayTask.MinSum(new int[] { 9, 2, 8, 7, 5, 4, 0, 6 }));

                }


                [Test]
                public void SumOfTheFirstNthTermOfSeriesTest()
                {
                    Assert.AreEqual("0.00", SumOfTheFirstNthTermOfSeriesTask.SeriesSum(0));
                    Assert.AreEqual("1.77", SumOfTheFirstNthTermOfSeriesTask.SeriesSum(9));

                }

                [Test]
                public void MaxDiffEasyTest()
                {
                    Assert.AreEqual(6, MaxDiffEasyTask.MaxDiff(new[] { 0, 1, 2, 3, 4, 5, 6 }));
                    Assert.AreEqual(11, MaxDiffEasyTask.MaxDiff(new[] { -0, 1, 2, -3, 4, 5, -6 }));
                    Assert.AreEqual(16, MaxDiffEasyTask.MaxDiff(new[] { 0, 1, 2, 3, 4, 5, 16 }));
                    Assert.AreEqual(0, MaxDiffEasyTask.MaxDiff(new[] { 16 }));
                    Assert.AreEqual(0, MaxDiffEasyTask.MaxDiff(new int[] { }));
                }

                [Test]
                public void SumOfTriangularNumbersTest()
                {
                    Assert.AreEqual(56, SumOfTriangularNumbersTask.SumTriangularNumbers(6));
                    Assert.AreEqual(7140, SumOfTriangularNumbersTask.SumTriangularNumbers(34));
                    Assert.AreEqual(0, SumOfTriangularNumbersTask.SumTriangularNumbers(-291));
                    Assert.AreEqual(140205240, SumOfTriangularNumbersTask.SumTriangularNumbers(943));
                    Assert.AreEqual(0, SumOfTriangularNumbersTask.SumTriangularNumbers(-971));
                }

                [Test]
                public void GreetMeTest()
                {
                    Assert.That(GreetMeTask.Greet("riley"), Is.EqualTo("Hello Riley!"));
                    Assert.That(GreetMeTask.Greet("DaRO"), Is.EqualTo("Hello Daro!"));
                }

                [Test]
                public static void FilterTheNumberTest()
                {
                    Assert.AreEqual(123, FilterTheNumberTask.FilterString("123"), "Just return the numbers");
                    Assert.AreEqual(123, FilterTheNumberTask.FilterString("a1b2c3"), "Just return the numbers");
                    Assert.AreEqual(123, FilterTheNumberTask.FilterString("aa1bb2cc3dd"), "Just return the numbers");
                }

                [Test]
                public void NumberOfDecimalDigitsTest()
                {
                    Assert.AreEqual(1, NumberOfDecimalDigitsTask.Digits(5ul));
                    Assert.AreEqual(5, NumberOfDecimalDigitsTask.Digits(12345ul));
                    Assert.AreEqual(10, NumberOfDecimalDigitsTask.Digits(9876543210ul));
                }
                [Test]
                public void SimpleBeadsCountTest()
                {
                    Assert.That(SimpleBeadsCountTask.CountRedBeads(0), Is.EqualTo(0));
                    Assert.That(SimpleBeadsCountTask.CountRedBeads(1), Is.EqualTo(0));
                    Assert.That(SimpleBeadsCountTask.CountRedBeads(3), Is.EqualTo(4));
                    Assert.That(SimpleBeadsCountTask.CountRedBeads(5), Is.EqualTo(8));
                }

                [Test]
                public void PredictYourAgeTest()
                {
                    Assert.AreEqual(86, PredictYourAgeTask.PredictAge(65, 60, 75, 55, 60, 63, 64, 45));
                    Assert.AreEqual(79, PredictYourAgeTask.PredictAge(32, 54, 76, 65, 34, 63, 64, 45));
                }

                [Test]
                public void ConvertAnArrayOfStringsToArrayOfNumbersTest()
                {
                    Assert.AreEqual(new double[] { 1.1, 2.2, 3.3 }, ConvertAnArrayOfStringsToArrayOfNumbersTask.ToDoubleArray(new string[] { "1.1", "2.2", "3.3" }));

                }

                [Test]
                public void SwitcherooTest()
                {
                    Assert.AreEqual("bac", SwitcherooTask.Switcheroo("abc"));
                    Assert.AreEqual("bbbacccabbb", SwitcherooTask.Switcheroo("aaabcccbaaa"));
                    Assert.AreEqual("ccccc", SwitcherooTask.Switcheroo("ccccc"));
                }

                [Test]
                public static void PartsOfAListTest()
                {
                    String[] s1 = new String[] { "cdIw", "tzIy", "xDu", "rThG" };
                    string[][] expected = new string[][] 
                    {
    
                        new string[] { "cdIw", "tzIy xDu rThG" },
    
                        new string[] { "cdIw tzIy", "xDu rThG" },
    
                        new string[] { "cdIw tzIy xDu", "rThG" }

                    };
                    CollectionAssert.AreEqual(expected, PartsOfAListTask.Partlist(s1));
                }

                [Test]
                public void LargestPairSumInArrayTest()
                {
                    Assert.AreEqual(-16, LargestPairSumInArrayTask.LargestPairSum(new int[] { -8, -8, -16, -18, -19 }));
                    Assert.AreEqual(0, LargestPairSumInArrayTask.LargestPairSum(new int[] { -100, -29, -24, -19, 19 }));
                    Assert.AreEqual(10, LargestPairSumInArrayTask.LargestPairSum(new int[] { 1, 2, 3, 4, 6, -1, 2 }));
                    Assert.AreEqual(42, LargestPairSumInArrayTask.LargestPairSum(new int[] { 10, 14, 2, 23, 19 }));
                }

                [Test]
                public void OddOrEvenTest()
                {
                    Assert.AreEqual("even", OddOrEvenTask.OddOrEven(new int[] { 0 }));
                    Assert.AreEqual("odd", OddOrEvenTask.OddOrEven(new int[] { 1 }));
                    Assert.AreEqual("even", OddOrEvenTask.OddOrEven(new int[] { }));
                }

                [Test]
				public void DeodorantEvaporatorTest()
				{
					Assert.AreEqual(22, DeodorantEvaporatorTask.Evaporator(10, 10, 10));
				}
				[Test]
				public void BuildASquareTest()
				{
					Assert.AreEqual("", BuildASquareTask.GenerateShape(0));
					Assert.AreEqual("+", BuildASquareTask.GenerateShape(1));
					Assert.AreEqual("++\n++", BuildASquareTask.GenerateShape(2));
					Assert.AreEqual("+++\n+++\n+++", BuildASquareTask.GenerateShape(3));
				}

				[Test]
				public void MostDigitsTest()
				{
					Assert.AreEqual(100, MostDigitsTask.FindLongest(new int[] { 1, 10, 100 }));
					Assert.AreEqual(9000, MostDigitsTask.FindLongest(new int[] { 9000, 8, 800 }));
					Assert.AreEqual(900, MostDigitsTask.FindLongest(new int[] { 8, 900, 500 }));
				}

				[Test]
				public void AlphabetWarTest()
				{
					Assert.AreEqual("Right side wins!", AlphabetWarTask.AlphabetWar("z"));
					Assert.AreEqual("Let's fight again!", AlphabetWarTask.AlphabetWar("zdqmwpbs"));
					Assert.AreEqual("Right side wins!", AlphabetWarTask.AlphabetWar("zzzzs"));
					Assert.AreEqual("Left side wins!", AlphabetWarTask.AlphabetWar("wwwwwwz"));
				}

				[Test]
                public void PowerOfTwoTest()
                {
                    Assert.AreEqual(true, PowerOfTwoTask.PowerOfTwo(4096));
                    Assert.AreEqual(true, PowerOfTwoTask.PowerOfTwo(2));
                    Assert.AreEqual(false, PowerOfTwoTask.PowerOfTwo(9));

                }

                [Test]
                public void SumofNumbersFrom0ToNTest()
                {
                    Assert.AreEqual("0+1+2+3+4+5+6 = 21", SumofNumbersFrom0ToNTask.ShowSequence(6));
                    Assert.AreEqual("-5<0", SumofNumbersFrom0ToNTask.ShowSequence(-5));
                    Assert.AreEqual("0=0", SumofNumbersFrom0ToNTask.ShowSequence(0));
                }

                [Test]
                public void MaximumProductTest()
                {
                    Assert.AreEqual(200, MaximumProductTask.AdjacentElementsProduct(new int[] { 40, 5, 8 }));
                    Assert.AreEqual(6, MaximumProductTask.AdjacentElementsProduct(new int[] { 6, 1, 2, 3, 0 }));
                    Assert.AreEqual(-14, MaximumProductTask.AdjacentElementsProduct(new int[] { -23, 4, -5, 99, -27, 329, -2, 7, -921 }));

                }

                [Test]
                public void SortArrayByStringLengthTest()
                {
                    Assert.AreEqual(new string[] { "I", "To", "Beg", "Life" }, SortArrayByStringLengthTask.SortByLength(new string[] { "Beg", "Life", "I", "To" }));
                    Assert.AreEqual(new string[] { "", "Pizza", "Brains", "Moderately" }, SortArrayByStringLengthTask.SortByLength(new string[] { "", "Moderately", "Brains", "Pizza" }));
                    Assert.AreEqual(new string[] { "Short", "Longer", "Longest" }, SortArrayByStringLengthTask.SortByLength(new string[] { "Longer", "Longest", "Short" }));
                }

                [Test]
                public void NoOdditiesHereTest()
                {
                    Assert.AreEqual(new int[] { 2, 4 }, NoOdditiesHereTask.NoOdds(new int[] { 1, 2, 3, 4, 5 }));
                }
                [Test]
                public void BumpsInTheRoadTest()
                {
                    Assert.AreEqual("Woohoo!", BumpsInTheRoadTask.Bump("n"));
                    Assert.AreEqual("Woohoo!", BumpsInTheRoadTask.Bump("nnn_n__n_n___nnnnn___n__nnn__"));
                    Assert.AreEqual("Car Dead", BumpsInTheRoadTask.Bump("_nnnnnnn_n__n______nn__nn_nnn"));
                    Assert.AreEqual("Car Dead", BumpsInTheRoadTask.Bump("nnnn____nnnnnn___nnnnnnnn_____nnnnnnn"));

                }
                [Test]
                public void JavaScriptArrayFilterTest()
                {
                    Assert.AreEqual(new int[] { 2 }, JavaScriptArrayFilterTask.GetEvenNumbers(new int[] { 1, 2 }));
                    Assert.AreEqual(new int[] { 2, 6, 8, 10 }, JavaScriptArrayFilterTask.GetEvenNumbers(new int[] { 2, 6, 8, 10 }));
                    Assert.AreEqual(new int[] { 12, 14 }, JavaScriptArrayFilterTask.GetEvenNumbers(new int[] { 12, 14, 15 }));
                    Assert.AreEqual(new int[] { }, JavaScriptArrayFilterTask.GetEvenNumbers(new int[] { 1, 3, 9 }));

                }

                [Test]
                public void AlanPartridgeIIILondonTest()
                {
                    Assert.AreEqual("Smell my cheese you mother!", AlanPartridgeIIILondonTask.Alan(new string[] { "Norwich", "Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway", "London" }));
                    Assert.AreEqual("No, seriously, run. You will miss it.", AlanPartridgeIIILondonTask.Alan(new string[] { "London", "Norwich" }));
                    Assert.AreEqual("Smell my cheese you mother!", AlanPartridgeIIILondonTask.Alan(new string[] { "Norwich", "Tooting", "Bank", "Rejection", "Disappointment", "Backstabbing Central", "Exeter", "Shattered Dreams Parkway", "Belgium", "London" }));
                }

                [Test]
                public void AnagramDetectionTest()
                {
                    Assert.AreEqual(true, AnagramDetectionTask.IsAnagram("foefet", "toffee"));
                    Assert.AreEqual(true, AnagramDetectionTask.IsAnagram("Buckethead", "DeathCubeK"));
                    Assert.AreEqual(true, AnagramDetectionTask.IsAnagram("Twoo", "Woot"));
                    Assert.AreEqual(false, AnagramDetectionTask.IsAnagram("apple", "pale"));

                }

                [Test]
                public void PartridgeWatchTest()
                {
                    Assert.AreEqual("Mine's a Pint!", PartridgeWatchTask.Part(new String[] { "Grouse", "Partridge", "Pheasant" }));
                    Assert.AreEqual("Mine's a Pint!!!!!!!!", PartridgeWatchTask.Part(new String[] { "Grouse", "Partridge", "Pheasant", "Goose", "Starling", "Robin", "Thrush", "Emu", "PearTree", "Chat", "Dan", "Square", "Toblerone", "Lynn", "AlphaPapa", "BMW", "Graham", "Tool", "Nomad", "Finger", "Hamster" }));
                    Assert.AreEqual("Lynn, I've pierced my foot on a spike!!", PartridgeWatchTask.Part(new string[] { "Pheasant", "Goose", "Starling", "Robin" }));
                }

                [Test]
                public static void TheCouponCodeTest()
                {
                    Assert.AreEqual(true, TheCouponCodeTask.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));
                    Assert.AreEqual(false, TheCouponCodeTask.CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"));

                }

                [Test]
                public void SortedYesOrNoTest()
                {
                    Assert.AreEqual("yes, ascending", SortedYesOrNoTask.IsSortedAndHow(new[] { 1, 2 }));
                    Assert.AreEqual("yes, descending", SortedYesOrNoTask.IsSortedAndHow(new[] { 15, 7, 3, -8 }));
                    Assert.AreEqual("no", SortedYesOrNoTask.IsSortedAndHow(new[] { 4, 2, 30 }));
                }

                [Test]
                public void RowSumOddNumbersTest()
                {
                    Assert.AreEqual(1, SumOfOddNumbersTask.RowSumOddNumbers(1));
                    Assert.AreEqual(74088, SumOfOddNumbersTask.RowSumOddNumbers(42));
                }

                [Test]
                public void ReverseLetterTest()
                {
                    Assert.AreEqual("nahsirk", ReverseLetterTask.ReverseLetter("krishan"));

                    Assert.AreEqual("nortlu", ReverseLetterTask.ReverseLetter("ultr53o?n"));

                    Assert.AreEqual("cba", ReverseLetterTask.ReverseLetter("ab23c"));

                    Assert.AreEqual("nahsirk", ReverseLetterTask.ReverseLetter("krish21an"));

                }

                [Test]
                public void MultipleOf5Test()
                {
                    Assert.AreEqual(0, MultipleOf5Task.RoundToNext5(0));
                    Assert.AreEqual(5, MultipleOf5Task.RoundToNext5(1));
                    Assert.AreEqual(5, MultipleOf5Task.RoundToNext5(3));
                    Assert.AreEqual(5, MultipleOf5Task.RoundToNext5(5));
                    Assert.AreEqual(10, MultipleOf5Task.RoundToNext5(7));
                    Assert.AreEqual(40, MultipleOf5Task.RoundToNext5(39));

                }


                [Test]
                public void CreateFactorialmethodTest()
                {
                    Assert.AreEqual(1, CreateFactorialmethodTask.Factorial(0));
                    Assert.AreEqual(1, CreateFactorialmethodTask.Factorial(1));
                    Assert.AreEqual(2, CreateFactorialmethodTask.Factorial(2));
                    Assert.AreEqual(6, CreateFactorialmethodTask.Factorial(3));
                    Assert.AreEqual(24, CreateFactorialmethodTask.Factorial(4));
                    Assert.AreEqual(120, CreateFactorialmethodTask.Factorial(5));
                }

                [Test]
                public void FindTheCapitalsTest()
                {
                    Assert.AreEqual(FindTheCapitalsTask.Capitals("CodEWaRs"), new int[] { 0, 3, 4, 6 });
                }

                [Test]
                public void SumOfAnglesTest()
                {
                    Assert.AreEqual(180, SumOfAnglesTask.Angle(3));
                    Assert.AreEqual(360, SumOfAnglesTask.Angle(4));
                }

                [Test]
                public void SumOfASequenceTest()
                {
                    Assert.AreEqual(12, SumOfASequenceTask.SequenceSum(2, 6, 2));
                    Assert.AreEqual(15, SumOfASequenceTask.SequenceSum(1, 5, 1));
                    Assert.AreEqual(5, SumOfASequenceTask.SequenceSum(1, 5, 3));
                    Assert.AreEqual(45, SumOfASequenceTask.SequenceSum(0, 15, 3));
                    Assert.AreEqual(0, SumOfASequenceTask.SequenceSum(16, 15, 3));
                    Assert.AreEqual(26, SumOfASequenceTask.SequenceSum(2, 24, 22));
                    Assert.AreEqual(2, SumOfASequenceTask.SequenceSum(2, 2, 2));
                    Assert.AreEqual(2, SumOfASequenceTask.SequenceSum(2, 2, 1));
                    Assert.AreEqual(35, SumOfASequenceTask.SequenceSum(1, 15, 3));
                    Assert.AreEqual(0, SumOfASequenceTask.SequenceSum(15, 1, 3));
                }

                [Test]
                public void SumOfMinimumsTest()
                {
                    Assert.AreEqual(26, SumOfMinimumsTask.SumOfMinimums(new int[3, 5] { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 20, 21, 34, 56, 100 } }));
                    Assert.AreEqual(9, SumOfMinimumsTask.SumOfMinimums(new int[3, 5] { { 7, 9, 8, 6, 2 }, { 6, 3, 5, 4, 3 }, { 5, 8, 7, 4, 5 } }));
                    Assert.AreEqual(76, SumOfMinimumsTask.SumOfMinimums(new int[4, 4] { { 11, 12, 14, 54 }, { 67, 89, 90, 56 }, { 7, 9, 4, 3 }, { 9, 8, 6, 7 } }));
                }

                [Test]
                public void ShortestWordTest()
                {
                    Assert.AreEqual(3, ShortestWordTask.FindShort("bitcoin take over the world maybe who knows perhaps"));
                    Assert.AreEqual(3, ShortestWordTask.FindShort("turns out random test cases are easier than writing out basic ones"));
                    Assert.AreEqual(2, ShortestWordTask.FindShort("Let's travel abroad shall we"));
                }

                [Test]
                public void AlternateCapitalizationTest()
                {
                    Assert.AreEqual(new string[2] { "AbCdEf", "aBcDeF" }, AlternateCapitalizationTask.Capitalize("abcdef"));
                    Assert.AreEqual(new string[2] { "CoDeWaRs", "cOdEwArS" }, AlternateCapitalizationTask.Capitalize("codewars"));
                    Assert.AreEqual(new string[2] { "AbRaCaDaBrA", "aBrAcAdAbRa" }, AlternateCapitalizationTask.Capitalize("abracadabra"));
                    Assert.AreEqual(new string[2] { "CoDeWaRrIoRs", "cOdEwArRiOrS" }, AlternateCapitalizationTask.Capitalize("codewarriors"));
                }

                [Test]
                public void TwoFightersOneWinnerTest()
                {
                    Assert.AreEqual("Lew", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Lew", 10, 2), new TwoFightersOneWinnerTask.Fighter("Harry", 5, 4), "Lew"));
                    Assert.AreEqual("Harry", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Lew", 10, 2), new TwoFightersOneWinnerTask.Fighter("Harry", 5, 4), "Harry"));
                    Assert.AreEqual("Harald", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Harald", 20, 5), new TwoFightersOneWinnerTask.Fighter("Harry", 5, 4), "Harry"));
                    Assert.AreEqual("Harald", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Harald", 20, 5), new TwoFightersOneWinnerTask.Fighter("Harry", 5, 4), "Harald"));
                    Assert.AreEqual("Harald", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Jerry", 30, 3), new TwoFightersOneWinnerTask.Fighter("Harald", 20, 5), "Jerry"));
                    Assert.AreEqual("Harald", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Jerry", 30, 3), new TwoFightersOneWinnerTask.Fighter("Harald", 20, 5), "Harald"));

                }

                [Test]
                public static void PerfectSquareTest()
                {
                    Assert.AreEqual(-1, PerfectSquareTask.FindNextSquare(155));
                    Assert.AreEqual(144, PerfectSquareTask.FindNextSquare(121));
                    Assert.AreEqual(676, PerfectSquareTask.FindNextSquare(625));
                    Assert.AreEqual(320356, PerfectSquareTask.FindNextSquare(319225));
                }

                [Test]
                public void SumDigitsTest()
                {
                    Assert.AreEqual(1, SumDigitsTask.SumDigits(10));
                    Assert.AreEqual(18, SumDigitsTask.SumDigits(99));
                    Assert.AreEqual(5, SumDigitsTask.SumDigits(-32));

                }

                [Test]
                public void FixStringCaseTest()
                {
                    Assert.AreEqual("code", FixStringCaseTask.Solve("code"));
                    Assert.AreEqual("CODE", FixStringCaseTask.Solve("CODe"));
                    Assert.AreEqual("code", FixStringCaseTask.Solve("COde"));
                    Assert.AreEqual("code", FixStringCaseTask.Solve("Code"));

                }

                [Test]
                public void FormTheMinimumTest()
                {
                    Assert.AreEqual(13, FormTheMinimumTask.MinValue(new int[] { 1, 3, 1 }));
                    Assert.AreEqual(457, FormTheMinimumTask.MinValue(new int[] { 4, 7, 5, 7 }));
                    Assert.AreEqual(148, FormTheMinimumTask.MinValue(new int[] { 4, 8, 1, 4 }));
                    Assert.AreEqual(579, FormTheMinimumTask.MinValue(new int[] { 5, 7, 9, 5, 7 }));
                }


                [Test]
                public void FactorialTest()
                {
                    Assert.AreEqual(1, FactorialTask.Factorial(0));
                    Assert.AreEqual(1, FactorialTask.Factorial(1));
                    Assert.AreEqual(2, FactorialTask.Factorial(2));
                    Assert.AreEqual(6, FactorialTask.Factorial(3));
                }

                [Test]
                public void CheckTheExamTest()
                {
                    Assert.AreEqual(7, CheckTheExamTask.CheckExam(new string[] { "a", "a", "c", "b" }, new string[] { "a", "a", "b", "" }));
                    Assert.AreEqual(6, CheckTheExamTask.CheckExam(new string[] { "a", "a", "b", "b" }, new string[] { "a", "c", "b", "d" }));
                    Assert.AreEqual(0, CheckTheExamTask.CheckExam(new string[] { "b", "c", "b", "a" }, new string[] { "", "a", "a", "c" }));
                }

                [Test]
                public void RemoveAnchorFromURLTest()
                {
                    Assert.AreEqual("www.codewars.com", RemoveAnchorFromURLTask.RemoveUrlAnchor("www.codewars.com#about"));
                    Assert.AreEqual("www.codewars.com/katas/?page=1", RemoveAnchorFromURLTask.RemoveUrlAnchor("www.codewars.com/katas/?page=1#about"));
                    Assert.AreEqual("www.codewars.com/katas/", RemoveAnchorFromURLTask.RemoveUrlAnchor("www.codewars.com/katas/"));
                }


                [Test]
                public void JadenCasingStringTest()
                {
                    Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real", JadenCasingStringTask.ToJadenCase("How can mirrors be real if our eyes aren't real"));
                }
                [Test]
                public void SmallEnoughTest()
                {
                    Assert.AreEqual(true, SmallEnoughTask.SmallEnough(new int[] { 66, 101 }, 200));
                    Assert.AreEqual(false, SmallEnoughTask.SmallEnough(new int[] { 78, 117, 110, 99, 104, 117, 107, 115 }, 100));
                    Assert.AreEqual(true, SmallEnoughTask.SmallEnough(new int[] { 101, 45, 75, 105, 99, 107 }, 107));
                    Assert.AreEqual(true, SmallEnoughTask.SmallEnough(new int[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 120));
                }

                [Test]
                public void TestingNumerationTest()
                {
                    Assert.AreEqual(new List<string>(), TestingNumerationTask.Number(new List<string>()));
                    Assert.AreEqual(new List<string> { "1: a", "2: b", "3: c" }, TestingNumerationTask.Number(new List<string> { "a", "b", "c" }));
                    Assert.AreEqual(new List<string> { "1: ", "2: ", "3: ", "4: ", "5: " }, TestingNumerationTask.Number(new List<string> { "", "", "", "", "" }));
                }


                [Test]
                public void SquareEveryDigitTest()
                {
                    Assert.AreEqual(811181, SquareEveryDigitTask.SquareDigits(9119));
                    Assert.AreEqual(0, SquareEveryDigitTask.SquareDigits(0));
                }


                [Test]
                public void MoneyTest()
                {
                    Assert.AreEqual(0, MoneyTask.CalculateYears(1000, 0.05, 0.18, 1000));
                    Assert.AreEqual(14, MoneyTask.CalculateYears(1000, 0.01625, 0.18, 1200));

                }

                [Test]
                public void SortNumbersTest()
                {
                    Assert.AreEqual(new int[] { 1, 2, 3, 5, 10 }, SortNumbersTask.SortNumbers(new int[] { 1, 2, 3, 10, 5 }));
                    Assert.AreEqual(new int[] { }, SortNumbersTask.SortNumbers(new int[] { }));
                    Assert.AreEqual(new int[] { 2, 10, 20 }, SortNumbersTask.SortNumbers(new int[] { 20, 2, 10 }));
                    Assert.AreEqual(new int[] { 1, 2, 3, 5, 10 }, SortNumbersTask.SortNumbers(new int[] { 1, 2, 3, 10, 5 }));
                    Assert.AreEqual(new int[] { 1, 2, 3, 5, 10 }, SortNumbersTask.SortNumbers(new int[] { 1, 2, 3, 10, 5 }));
                }

                [Test]
                public void ExesAndOhsTest()
                {
                    Assert.AreEqual(true, ExesAndOhsTask.XO("xo"));
                    Assert.AreEqual(true, ExesAndOhsTask.XO("xxOo"));
                    Assert.AreEqual(false, ExesAndOhsTask.XO("xxxm"));
                    Assert.AreEqual(false, ExesAndOhsTask.XO("Oo"));
                    Assert.AreEqual(false, ExesAndOhsTask.XO("ooom"));
                }

                [Test]
                public void PeopleInTheBusTest()
                {

                    Assert.AreEqual(5, PeopleInTheBusTask.Number(new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } }));
                    Assert.AreEqual(17, PeopleInTheBusTask.Number(new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } }));
                    Assert.AreEqual(21, PeopleInTheBusTask.Number(new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } }));
                }

                [Test]
                public static void TwoToOneSortedStringTest()
                {
                    Assert.AreEqual("aehrsty", TwoToOneSortedStringTask.Longest("aretheyhere", "yestheyarehere"));
                    Assert.AreEqual("abcdefghilnoprstu", TwoToOneSortedStringTask.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
                    Assert.AreEqual("acefghilmnoprstuy", TwoToOneSortedStringTask.Longest("inmanylanguages", "theresapairoffunctions"));
                }

                [Test]
                public void SumOfNumbersInSequenceTest()
                {
                    Assert.AreEqual(1, SumOfNumbersInSequenceTask.GetSum(0, 1));
                    Assert.AreEqual(-1, SumOfNumbersInSequenceTask.GetSum(0, -1));
                }


                [Test]
                public void FindTheStrayNumberTest()
                {
                    Assert.AreEqual(2, FindTheStrayNumberTask.Stray(new int[] { 1, 1, 2 }));
                }

                [Test]
                public void ListFilteringTest()
                {
                    var list = new List<object>() { 1, 2, "a", "b" };
                    var expected = new List<int>() { 1, 2 };
                    var actual = ListFilteringTask.GetIntegersFromList(list);
                    Assert.IsTrue(expected.SequenceEqual(actual));
                }

                [Test]
                public static void GrowthOfAPopulationTest()
                {
                    Assert.AreEqual(15, GrowthOfAPopulationTask.NbYear(1500, 5, 100, 5000));
                    Assert.AreEqual(10, GrowthOfAPopulationTask.NbYear(1500000, 2.5, 10000, 2000000));
                    Assert.AreEqual(94, GrowthOfAPopulationTask.NbYear(1500000, 0.25, 1000, 2000000));
                }

                [Test]
                public void HighestAndLowestTest()
                {
                    Assert.AreEqual("42 -9", HighestAndLowestTask.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
                    Assert.AreEqual("3 1", HighestAndLowestTask.HighAndLow("1 2 3"));

                }

                [Test]
                public static void RemoveTheMinimumTest()
                {
                    Assert.AreEqual(new List<int> { 2, 3, 4, 5 }, RemoveTheMinimumTask.RemoveSmallest(new List<int> { 1, 2, 3, 4, 5 }));
                    Assert.AreEqual(new List<int> { 5, 3, 2, 4 }, RemoveTheMinimumTask.RemoveSmallest(new List<int> { 5, 3, 2, 1, 4 }));
                    Assert.AreEqual(new List<int> { 2, 3, 1, 1 }, RemoveTheMinimumTask.RemoveSmallest(new List<int> { 1, 2, 3, 1, 1 }));
                    Assert.AreEqual(new List<int>(), RemoveTheMinimumTask.RemoveSmallest(new List<int>()));
                }

                [Test]
                public void SumTwoSmallestNumbersTest()
                {
                    Assert.AreEqual(13, SumTwoSmallestNumbersTask.SumTwoSmallestNumbers(new int[] { 5, 8, 12, 19, 22 }));
                    Assert.AreEqual(7, SumTwoSmallestNumbersTask.SumTwoSmallestNumbers(new int[] { 19, 5, 42, 2, 77 }));
                    Assert.AreEqual(3453455, SumTwoSmallestNumbersTask.SumTwoSmallestNumbers(new int[] { 10, 343445353, 3453445, 2147483647 }));
                }

                [Test]
                public void BinaryAdditionTest()
                {
                    Assert.AreEqual("11", BinaryAdditionTask.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
                }

                [Test]
                public void DescendingOrderTest()
                {
                    Assert.AreEqual(0, DescendingOrderTask.DescendingOrder(0));
                    Assert.AreEqual(54421, DescendingOrderTask.DescendingOrder(42145));
                    Assert.AreEqual(987654321, DescendingOrderTask.DescendingOrder(123456789));
                }

                [Test]
                public void OnesAndZerosTest()
                {
                    Assert.AreEqual(0, OnesAndZerosTask.binaryArrayToNumber(new int[] { 0, 0, 0, 0 }));
                    Assert.AreEqual(15, OnesAndZerosTask.binaryArrayToNumber(new int[] { 1, 1, 1, 1 }));
                    Assert.AreEqual(6, OnesAndZerosTask.binaryArrayToNumber(new int[] { 0, 1, 1, 0 }));
                    Assert.AreEqual(5, OnesAndZerosTask.binaryArrayToNumber(new int[] { 0, 1, 0, 1 }));
                }

                [Test]
                public void CountTheDivisorsOfANumberTest()
                {
                    Assert.AreEqual(1, CountTheDivisorsOfANumberTask.Divisors(1));
                    Assert.AreEqual(4, CountTheDivisorsOfANumberTask.Divisors(10));
                    Assert.AreEqual(2, CountTheDivisorsOfANumberTask.Divisors(11));
                    Assert.AreEqual(8, CountTheDivisorsOfANumberTask.Divisors(54));
                }

                [Test]
                public void ValidatePinTest()
                {
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("1"), "Wrong output for \"1\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("12"), "Wrong output for \"12\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("123"), "Wrong output for \"123\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("12345"), "Wrong output for \"12345\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("1234567"), "Wrong output for \"1234567\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("-1234"), "Wrong output for \"-1234\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("1.234"), "Wrong output for \"1.234\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("-1.234"), "Wrong output for \"-1.234\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("00000000"), "Wrong output for \"00000000\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("a234"), "Wrong output for \"a234\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin(".234"), "Wrong output for \".234\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("1234"), "Wrong output for \"1234\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("0000"), "Wrong output for \"0000\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("1111"), "Wrong output for \"1111\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("123456"), "Wrong output for \"123456\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("098765"), "Wrong output for \"098765\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("000000"), "Wrong output for \"000000\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("090909"), "Wrong output for \"090909\"");
                }

                [Test]
                public static void IsSquareTest()
                {
                    Assert.AreEqual(false, IsSquareTask.IsSquare(-1), "negative numbers aren't square numbers");
                    Assert.AreEqual(false, IsSquareTask.IsSquare(3), "3 isn't a square number");
                    Assert.AreEqual(true, IsSquareTask.IsSquare(4), "4 is a square number");
                    Assert.AreEqual(true, IsSquareTask.IsSquare(25), "25 is a square number");
                    Assert.AreEqual(false, IsSquareTask.IsSquare(26), "26 isn't a square number");
                }

                [Test]
                public void GetTheMiddleCharacterTest()
                {
                    Assert.AreEqual("es", GetTheMiddleCharacterTask.GetMiddle("test"));
                    Assert.AreEqual("t", GetTheMiddleCharacterTask.GetMiddle("testing"));
                    Assert.AreEqual("dd", GetTheMiddleCharacterTask.GetMiddle("middle"));
                    Assert.AreEqual("A", GetTheMiddleCharacterTask.GetMiddle("A"));
                }

                [Test]
                public void StringEndsWithTest()
                {
                    Assert.AreEqual(true, StringEndsWithTask.Solution("samurai", "ai"));
                    Assert.AreEqual(false, StringEndsWithTask.Solution("sumo", "omo"));
                    Assert.AreEqual(false, StringEndsWithTask.Solution("ails", "fails"));
                    Assert.AreEqual(true, StringEndsWithTask.Solution("ninja", "ja"));
                    Assert.AreEqual(true, StringEndsWithTask.Solution("!@#$%^&*() :-)", ":-)"));
                }

                [Test]
                public void IsTriangleTest()
                {
                    Assert.IsTrue(IsTriangleTask.IsTriangle(5, 7, 10));
                }

                [Test]
                public void CategorizeNewMemberTest()
                {
                    Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, CategorizeNewMemberTask.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
                    Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, CategorizeNewMemberTask.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
                    Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, CategorizeNewMemberTask.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));
                }

                [Test]
                public void DisemvowelTrollsTest()
                {
                    Assert.AreEqual("Ths wbst s fr lsrs LL!", Kata.Disemvowel("This website is for losers LOL!"));
                    Assert.AreEqual("Wht r y,  cmmnst?", Kata.Disemvowel("What are you, a communist?"));
                    Assert.AreEqual("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd", Kata.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
                }

                [Test]
                public void VowelCountTest()
                {
                    Assert.AreEqual(5, VowelCountTask.GetVowelCount("abracadabra"));
                }

                [Test]
                public static void MinMaxTest()
                {
                    Assert.AreEqual(new int[] { -1, 20 }, MinMaxTask.minMax(new int[] { 1, 2, 5, -1, 12, 20 }));
                    Assert.AreEqual(new int[] { 1, 5 }, MinMaxTask.minMax(new int[] { 1, 2, 3, 4, 5 }));
                    Assert.AreEqual(new int[] { -3, 5 }, MinMaxTask.minMax(new int[] { 1, 2, -3, 4, 5 }));
                }

                [Test]
                public static void PrinterErrorTest()
                {
                    Assert.AreEqual("3/56", PrinterErrorTask.PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));
                }

                [Test]
                public void IsIsogramTest()
                {
                    Assert.AreEqual(expected: true, actual: IsIsogramTask.IsIsogram("Dermatoglyphics"));
                    Assert.AreEqual(expected: true, actual: IsIsogramTask.IsIsogram("isogram"));
                    Assert.AreEqual(expected: false, actual: IsIsogramTask.IsIsogram("moose"));
                    Assert.AreEqual(expected: false, actual: IsIsogramTask.IsIsogram("isIsogram"));
                }

                [Test]
                public static void AccumTest()
                {
                    Assert.AreEqual("N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb", AccumTask.Accum("NyffsGeyylB"));
                    Assert.AreEqual("M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu", AccumTask.Accum("MjtkuBovqrU"));
                    Assert.AreEqual("E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm", AccumTask.Accum("EvidjUnokmM"));
                }
                [Test]
                public void ReverseWordsTest()
                {
                    Assert.AreEqual("sihT si na !elpmaxe", ReverseWordsTask.ReverseWords("This is an example!"));
                }

                [Test]
                public void FriendOrFoeTest()
                {
                    string[] expected = { "Ryan", "Mark" };
                    string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
                    CollectionAssert.AreEqual(expected, FriendOrFoeTask.FriendOrFoe(names));
                }
                [Test]
                public void MakeComplementTest()
                {
                    Assert.That(MakeComplementTask.MakeComplement("ATGC"), Is.EqualTo("TACG"));
                    Assert.That(MakeComplementTask.MakeComplement("AAGG"), Is.EqualTo("TTCC"));
                    Assert.That(MakeComplementTask.MakeComplement("ATTGC"), Is.EqualTo("TAACG"));
                }

            }
        }
    }
}