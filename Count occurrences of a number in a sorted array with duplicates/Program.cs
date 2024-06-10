internal class Program
{
    public static int CountOcurrences(int[] array, int left, int right, int key)
    {
        int result = -1;
        int first = -1;

        while(left <= right)
        {
            int m = left + (right - left) / 2;

            if(array[m] == key)
            {
                if(array[left] < key)
                {
                    first = m;
                }

                result = 1 + (m - first);
                left = m + 1;
            }

            if(key < array[m])
            {
                right = m - 1;
            } else if(key > array[m])
            {
                left = m + 1;
            }
        }

        return result;
    }

    private static void Main(string[] args)
    {
       int key = 6;
       int[] array = [2, 5, 5, 5, 6, 6, 8, 9, 9, 9];

       var ocurrences = CountOcurrences(array, 0, array.Length - 1, key);
       
       if(ocurrences == -1)
       {
          Console.WriteLine($"Key {key} not found");
       } else 
       {
          Console.WriteLine($"Number of Ocurrences {ocurrences}");
       }
    }
}


