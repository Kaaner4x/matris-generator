namespace MatrisGenerator
{
    internal class Program
    {
        static Random random = new Random();

        static void Main()
        {
            Console.Write("Number of dimensions: ");
            int dimensionCount = int.Parse(Console.ReadLine());

            int[] dimensions = new int[dimensionCount];

            for (int i = 0; i < dimensionCount; i++)
            {
                Console.Write($"Size of dimension {i + 1}: ");
                dimensions[i] = int.Parse(Console.ReadLine());
            }

            Array matrix = Array.CreateInstance(typeof(int), dimensions);

            int[] indices = new int[dimensionCount];

            FillWithRandomNumbers(matrix, indices, 0);

            Console.WriteLine("\nMatrix created and filled with random numbers.\n");

            PrintMatrix(matrix, indices, 0);
        }

        static void FillWithRandomNumbers(Array array, int[] indices, int level)
        {
            if (level == array.Rank)
            {
                array.SetValue(random.Next(1, 101), indices);
                return;
            }

            for (int i = 0; i < array.GetLength(level); i++)
            {
                indices[level] = i;
                FillWithRandomNumbers(array, indices, level + 1);
            }
        }

        static void PrintMatrix(Array array, int[] indices, int level)
        {
            if (level == array.Rank)
            {
                Console.WriteLine(
                    $"[{string.Join(", ", indices)}] = {array.GetValue(indices)}");
                return;
            }

            for (int i = 0; i < array.GetLength(level); i++)
            {
                indices[level] = i;
                PrintMatrix(array, indices, level + 1);
            }
        }
    }
}
