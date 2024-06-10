
internal class Program
{

    public static int SearchElement(int[] array, int left, int right, int key)
    {
        if(left <= right)
        {
            int mid = left + (right - left) / 2;

            if(array[mid] == key)
            {
                return mid;
            }

            if(array[mid] <= array[right])
            {
                if(key > array[mid] && key <= array[right])
                {
                    return SearchElement(array, mid + 1, right, key);
                } else 
                {
                    return SearchElement(array, left, mid - 1, key);
                }
            } else 
            {
                if(key < array[mid] && key >= array[left])
                {
                    return SearchElement(array, left, mid - 1, key);
                } else 
                {
                    return SearchElement(array, mid + 1, right, key);
                }
            }
           
        }

        return -1;
    }

    private static void Main(string[] args)
    {
        int key = 5;
        int[] array = {8, 9, 10, 2, 5, 6};

        var index = SearchElement(array, 0, array.Length - 1, key);

        if(index == -1)
        {
            Console.WriteLine($"Key {key} is not found");
        } else 
        {
            Console.WriteLine($"key {key} found at index {index}");
        }
    }
}