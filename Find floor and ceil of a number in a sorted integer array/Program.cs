internal class Program
{
    public static int Ceil(int[] array, int left, int right, int key)
    {
        int ceil = -1;

        while (left <= right)
        {
            int m = left + (right - left) / 2;

            if(key == array[m])
            {
                ceil = array[m];
                break;
            } 

            if (key < array[m])
            {
                ceil = array[m];
                right = m - 1;
            } else if(key > array[m])
            {
                left = m + 1;
            }  
        }

        return ceil;
    }

    public static int Floor(int[] array, int left, int right, int key)
    {
        int floor = -1;

        while (left <= right)
        {
            int m = right + (left - right) / 2;

            if(key == array[m])
            {
                floor = array[m];
                break;
            }

            if(key < array[m])
            {
                right = m - 1;
            } else if(key > array[m])
            {
                floor = array[m];
                left = m + 1;
            }
        }

        return floor;
    }

    private static void Main(string[] args)
    {
        int[] array = [1, 4, 6, 8, 9];
        for (int i = 0; i <= 10; i++)
        {
            Console.Write($"Number {i} -> ceil is {Ceil(array, 0, array.Length - 1, i)}, ");
            Console.WriteLine($"floor is {Floor(array, 0, array.Length - 1, i)}");
        }
    }
}