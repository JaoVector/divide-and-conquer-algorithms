internal class Program
{
    public static int SmallestMissing(int[] array, int left, int right)
    {

       int small = -1;
       while(left <= right)
       {
           int m = left + (right - left) / 2;

           if(array[m] == m && m == array.Length - 1)
           {
               small = array.Length;
               break;
           } 

           if(m == array[m])
           {
              left = m + 1;
           } else 
           {
              if(m < array[m] || small < m)
              {
                 small = m;
              }

              right = m - 1;
           }
       } 
       
       return small;

    }

    public static int[] InsertionSort(int[] array)
    {

       for (int i = 0; i < array.Length; i++)
       {
           var key = array[i];
           int j = i - 1;

           while (j >= 0 && array[j] > key)
           {
                array[j + 1] = array[j];
                j--;
           } 

           array[j + 1] = key;
       }

        return array;
    }

    private static void Main(string[] args)
    {
        int[] unsorted = [10, 2, 8, 1, 4, 6, 5, 7, 9, 0];
        int[] array = [0, 1, 2, 6, 9, 11, 15];
        int[] array2 = [1, 2, 3, 4, 6, 9, 11, 15];
        int[] array3 = [0, 1, 2, 3, 4, 5, 6];

       // var sorted = InsertionSort(unsorted);


        var index = SmallestMissing(array3, 0, array3.Length - 1);

        Console.WriteLine(index);
    }
}