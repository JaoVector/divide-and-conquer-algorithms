

internal class Program
{

    public static int Rotations(int[]array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            if(array[left] <= array[right])
            {
                return left;
            }

            int m = left + (right - left) / 2;

            //Calcula o proximo elemento e o anterior do elemento m para um 
            // array circular
            int next = (m + 1) % array.Length;
            int prev = (m - 1 + array.Length) % array.Length;

            //verifica se o elemento na posicao m é menor que seu vizinho da direita e esquerda
            // se não for continua a busca
            if(array[m] <= array[next] && array[m] <= array[prev])
            {
                return m;
            } else if(array[m] <= array[right])
            {
                right = m - 1;
            } else if(array[m] >= array[left])
            {
                left = m + 1;
            }
        }

        return -1;
    }

    private static void Main(string[] args)
    {
        int[] array = {8, 9, 10, 1, 2, 3, 4, 5, 6, 7};

        Console.WriteLine($"Array is Rotated {Rotations(array)}");
    }
}