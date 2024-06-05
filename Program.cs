

class Program
{
    static void Main(string[] args)
    {
        int[] arrayCriado = { 3, 1, 6, 4, 5, 2 };

        static int[] SelectionSort(int[] array)
        {
            int min, aux;
            for (int i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                        min = j;
                }
                if (min != i)
                {
                    aux = array[min];
                    array[min] = array[i];
                    array[i] = aux;
                }
            }
            return array;
        }

        SelectionSort(arrayCriado);

        foreach (int a in arrayCriado)
        {
            Console.WriteLine(a);
        }
    } 
}
