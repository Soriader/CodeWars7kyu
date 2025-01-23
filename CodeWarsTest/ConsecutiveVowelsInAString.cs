using CodeWars7kyu;

namespace CodeWarsTest;

public class ConsecutiveVowelsInAString
{
    [Test]
    public void ConsecutiveVowelsInAStringTest()
    {
        Assertion(0, string.Empty);
        Assertion(6, "agrtertyfikfmroyrntbvsukldkfa");
        Assertion(4, "erfaiekjudhyfimngukduo");
        Assertion(7, "akfheujfkgiaaaofmmfkdfuaiiie");
        Assertion(0, "eiknfhjrytueiouesxdczbeuiuoimnmfhfiuou");
        Assertion(16, "desrehakkjfuteknvfiyrtfbehjdjrobchrunbcbbhdhehbvudjsnanbakkjndhfjenfndinmfnbfondndendnfudnfnanndhdemdmcnfdemnfjimdfofnmfnfjanmdnhdua");
        Assertion(11, "sudnfhrakekdhhfkakjdjdhvneidkvnudntomcnnamjemdmfudkfhjamvcjedkfdnridnmnbvfhbdjdidncbvchencchdjdodncvchfndnrnencncnffduncbhjdfja");
        Assertion(11, "jurjfdleiifjriisiouajjfyhekkfjvnnmsuimsnvyuhvcodnmfnsumvbjshhsadkvhfeixoua");
        Assertion(3, "jrknjffuolgtahamhaevbgeosreljtbhuiaamxpyxdmyb");
        Assertion(6, "sowqapfqbrjpygtmmulybwusgjijbrnchgkxiaazkcniaxllmupjcmkxwcsmzdaessgkkgzctmbchladughtkitcognxvjwiiiltkuebrwemopvxqpeurfsfgjmeuzgvhjnssbhwkfbejzygbytipjtdcyscwofrpwshiakbdnqfioxqulohdlnmmmfpfrriwpwbddpj");

        static void Assertion(int expected, string input) =>Assert.AreEqual(expected, ConsecutiveVowelsInAStringTask.GetTheVowels(input), $"\n  Word: \"{input}\"");
    }
}