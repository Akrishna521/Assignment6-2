using System;

class MatrixProgram
{
    static void Main()
    {
        // Create a 2D matrix (assuming it's a jagged array for simplicity)
        int[][] matrix = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };

        // Task 2.1: Access and store the value of the second element in the first row
        int elementValue = matrix[0][1];

        // Task 2.2: Display the entire matrix using a nested loop
        Console.WriteLine("Matrix:");

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }

            Console.WriteLine(); // Move to the next row
        }

        // Display the value of the second element in the first row
        Console.WriteLine($"Value of the second element in the first row: {elementValue}");
    }
}