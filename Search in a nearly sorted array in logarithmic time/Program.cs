internal class Program
{
    public static int LogarithmicTime(int[] array, int left, int right, int key)
    {
        if(left <= right)
        {
            int mid = left + (right - left) / 2;
        
            int rsp = key switch
            {
                _ when key == array[mid] => mid,
                _ when key == array[mid - 1] => mid - 1,
                _ when key == array[mid + 1] => mid + 1,
                _ => -1
            };

            if(rsp != -1)
            {
                return rsp;
            }
           
            if(key < array[mid])
            {
                return LogarithmicTime(array, left, mid - 2, key);
            } else
            {
                return LogarithmicTime(array, mid + 2, right, key );
            }
        }

        return -1;
    }

    private static void Main(string[] args)
    {
        int key = 3;
        int[] array = [2, 1, 3, 5, 4, 7, 6, 8, 9];

        var index = LogarithmicTime(array, 0, array.Length - 1, key);

        if(index == -1)
        {
            Console.WriteLine($"Key {key} is not found");
        } else
        {
            Console.WriteLine($"Key {key} found at index {index}");
        }
    }
}