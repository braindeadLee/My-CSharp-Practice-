
namespace Cylinders
{
    /// <summary>
    /// Erm what the sigma.
    /// </summary>
    class ArraysAndForeach
    {
        public static void Run()
        {
            //Array Ranges, grabbing a section within an array

            int[] allScores = new int[10];


            for (int i = 0; i < allScores.Length; i++) allScores[i] = i * 10;

            for (int i = 0; i < allScores.Length; i++) Console.WriteLine($"{allScores[i]}");

            int[] lowestScores = allScores[0..3];
            //lowestScores is indices 0-2 of allScores

            int[] highestScores = allScores[7..^0];
            //highestScores is indices 7-9 of allScores

            foreach (int score in highestScores) Console.WriteLine($"highestScore = {score}");

            //multi-dimensional arrays

            //traditionally, the main array and smaller arrays must be initialized independently
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2 };
            matrix[1] = new int[] { 3, 4, 5 };
            matrix[2] = new int[] { 6, 7, 8, 9 };

            //can also be expressed like this

            int[,] nuMatrix = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            // and its members called like this
            nuMatrix[0, 0] = 0;
            nuMatrix[2, 1] = 7;

            int rowLength = nuMatrix.GetLength(0);
            int colLength = nuMatrix.GetLength(1);
            //row length is 3, and column length is 2

        }
    }
}