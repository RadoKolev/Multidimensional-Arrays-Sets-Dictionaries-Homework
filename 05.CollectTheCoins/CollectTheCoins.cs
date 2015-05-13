﻿using System;

class CollectTheCoins
{
    static void Main()
    {
        char [][] board = new char[4][];

        for (int i = 0; i < 4; i++)
        {
            board[i] = Console.ReadLine().ToCharArray();
        }

        char[] move = Console.ReadLine().ToCharArray();
        int row = 0;
        int col = 0;
        int coins = 0;
        int hits = 0;

        for (int i = 0; i < move.Length; i++)
        {
            switch (move[i])
            {
                case '<':
                    if (col - 1 < 0)
                    {
                        hits++;
                        continue;
                    }
                    col -= 1;
                    break;
                case '>':
                    if (col + 1 >= board[row].Length)
                    {
                        hits++;
                        continue;
                    }
                    col += 1;
                    break;
                case '^':
                    if ((row - 1 < 0) || (col >= board[row - 1].Length))
                    {
                        hits++;
                        continue;
                    }
                    row -= 1;
                    break;
                default:
                    if ((row + 1 > 3) || (col >= board[row + 1].Length))
                    {
                        hits++;
                        continue;
                    }
                    row += 1;
                    break;
            }
            coins += (board[row][col] == '$') ? 1 : 0;
        }

        Console.WriteLine("Coins collected: " + coins);
        Console.WriteLine("Walls hit: " + hits);
    }
}