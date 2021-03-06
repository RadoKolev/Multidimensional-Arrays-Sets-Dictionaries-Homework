﻿using System;

class MatrixShuffling
{
    static void Main()
    {
        Console.Write("Please enter the number of the rows: ");
        int inputRows = int.Parse(Console.ReadLine());

        Console.Write("Please enter the number of the columns: ");
        int inputColumns = int.Parse(Console.ReadLine());

        string[,] matrix = new string[inputRows, inputColumns];

        for (int row = 0; row < inputRows; row++)
        {
            for (int col = 0; col < inputColumns; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }
        string input = Console.ReadLine();
        while (input != "END")
        {
            string[] command;
            command = Console.ReadLine().Split();
            if (command[0] == "swap" && command.Length == 5)
            {
                int rowX1 = int.Parse(command[1]);
                int colY1 = int.Parse(command[2]);
                int rowX2 = int.Parse(command[3]);
                int colY2 = int.Parse(command[4]);
                if (rowX1 > inputRows && colY1 > inputColumns && rowX2 > inputRows && colY2 > inputColumns)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    Console.WriteLine("(After swapping {0} and {1}):", matrix[rowX1, colY1], matrix[rowX2, colY2]);
                    string temp = matrix[rowX1, colY1];
                    matrix[rowX1, colY1] = matrix[rowX2, colY2];
                    matrix[rowX2, colY2] = temp;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }

            }
            else if (command[0] == "END")
            {
                input = "END";
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}