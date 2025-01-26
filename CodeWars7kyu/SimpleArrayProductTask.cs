namespace CodeWars7kyu;

public class SimpleArrayProductTask
{
    public static int SimpleArray(int[][] arr)
    {
        return GetMaxProduct(arr, 0, 1);
    }
    private static int GetMaxProduct(int[][] arr, int depth, int currentProduct)
    {
        if (depth == arr.Length)
        {
            return currentProduct;
        }

        int result = int.MinValue;

        foreach (int num in arr[depth])
        {
            result = Math.Max(result, GetMaxProduct(arr, depth + 1, currentProduct * num));
        }

        return result;
    }
}