// 01.a) Write a program that fills and prints a matrix of 
// size (n, n) as shown below: (examples for n = 4)

////      1	  5  9   13      1   4   7
////      2	  6  10  14      2   5   8
////      3	  7  11  15      3   6   9
////      4	  8  12  16      

// work fine!

using System;

class FillsAndPrintsAMatrix_1a
{
    static void Main()
    {
        bool parseSuccess;
        int inputN; 
        do
        {
            Console.Write("Input positive number N: ");
            string strA = Console.ReadLine();
            parseSuccess = int.TryParse(strA, out inputN);
        }
        while ((inputN <= 0) || (inputN > int.MaxValue) || (!parseSuccess));

        int[,] matrix = new int[inputN, inputN];

        int[] arrayForNumbers = new int[(inputN * inputN)]; // next is index of this array
        for (int i = 0; i < arrayForNumbers.Length; i++)
        {
            arrayForNumbers[i] = i + 1;
        }

        Console.WriteLine("\n");

        int index = 0;
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                matrix[row, col] = arrayForNumbers[index];
                index++;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0 , -4}", matrix[row, col]); 
            }
            Console.WriteLine();
        }
    }
}