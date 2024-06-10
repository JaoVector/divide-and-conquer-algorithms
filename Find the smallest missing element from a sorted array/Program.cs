
internal class Program
{
    public static int SmallestMissing(int[] array, int left, int right)
    {
        int slest = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if(array.Length - 1 == left)
            {
                slest = array.Length;
            }

            if(array[mid] == mid)
            {
                left = mid + 1;

            } else if(mid < array[mid])
            {
                slest = mid;
                right = mid - 1;
            } 
        }

        return slest;
    }

    private static void Main(string[] args)
    {
        int[] array = [0, 1, 2, 6, 9, 11, 15];
        int[] array2 = [1, 2, 3, 4, 6, 9, 11, 15];
        int[] array3 = [0, 1, 2, 3, 4, 5, 6];

        var smallest1 = SmallestMissing(array, 0, array.Length - 1);
        var smallest2 = SmallestMissing(array2, 0, array2.Length - 1);
        var smallest3 = SmallestMissing(array3, 0, array3.Length - 1);

        Console.WriteLine($"The smallest missing element is {smallest1}");
        Console.WriteLine($"The smallest missing element is {smallest2}");
        Console.WriteLine($"The smallest missing element is {smallest3}");
    }
}