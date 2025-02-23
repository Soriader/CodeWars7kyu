namespace CodeWars7kyu;

public class SimpleStringDivisionTask
{
    public static long Solve(string st, int k)
    {
        List<long> partitions = new List<long>();
        GeneratePartitions(st, k, 0, new List<string>(), partitions);
        return partitions.Max();
    }

    private static void GeneratePartitions(string st, int k, int index, List<string> currentParts, List<long> partitions)
    {
        if (k == 0)
        {
            string lastPart = st.Substring(index);
            currentParts.Add(lastPart);
            partitions.Add(currentParts.Select(long.Parse).Max());
            currentParts.RemoveAt(currentParts.Count - 1);
            return;
        }

        for (int i = index + 1; i <= st.Length - k; i++)
        {
            string part = st.Substring(index, i - index);
            currentParts.Add(part);
            GeneratePartitions(st, k - 1, i, currentParts, partitions);
            currentParts.RemoveAt(currentParts.Count - 1);
        }
    }
}
//https://www.codewars.com/kata/5b83c1c44a6acac33400009a/train/csharp