internal class Program
{
    public static void FirstLast(int[] array, int left, int right, int key)
    {
        if (left <= right)
        {
            int m = left + (right - left) / 2;

            if(array[m] == key && array[m] > array[left])
            {
                int first = m;
                int last = m;
                
                if(right == array.Length - 1 && left == 0)
                    last -= 1;

                while(array[m] == key && m < right)
                {
                    last++;
                    m++;
                }

                Console.WriteLine($"First Ocurrence {first}");
                Console.WriteLine($"Last Ocurrence {last}");
                return;
            }
        
            if(key < array[m])
            {
                FirstLast(array, left, m - 1, key);
            }

            if(key > array[m])
            {
                FirstLast(array, m + 1, right, key);
            }
        } else 
        {
            Console.WriteLine("Element not found in the array");
            return;
        }
    }

    private static void Main(string[] args)
    {
        int[] array = {2, 5, 5, 5, 6, 6, 8, 9, 9, 9};
        int key = 5;

        FirstLast(array, 0, array.Length - 1, key);
    }
}