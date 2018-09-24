/*
 Завдання 2.
 Створити статичні методи для роботи з рваним 2-вимірним масивом(масив масивів).
	- заповнення масиву випадковими числами
	- вивід  на екран
	- циклічний зсув рядків матриці вверх на певну кількість рядків
	- циклічний зсув рядків матриці вниз на певну кількість рядків
 */

using System;

namespace _02_torn_array
{
    class Program
    {
        // заповнення масиву випадковими числами
        static void FillRand(int [][] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = rand.Next(0, 100);
            }
        }

        // вивід  на екран
        static void Print(int [][] arr, string message = "")
        {
            Console.WriteLine(message);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write($"{arr[i][j]}\t");
                Console.WriteLine();
            }
        }

        // циклічний зсув рядків матриці вверх на певну кількість рядків
        static void ToUp(int[][] arr, int up)
        {
            for (int k = 0; k < up; k++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int[] tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                }
            }
        }

        // циклічний зсув рядків матриці вниз на певну кількість рядків
        static void ToDown(int[][] arr, int down)
        {
            for (int k = 0; k < down; k++)
            {
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    int[] tmp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = tmp;
                }
            }
        }

        static void Main(string[] args)
        {

            int[][] arr = new int[4][]
          {
                new int[1],
                new int[2],
                new int[3],
                new int[4]
          };

            FillRand(arr);
            Print(arr, "Begin array:");
            //ToUp(arr, 1);
            //Print(arr, "\nUp to 1 rows:");
            ToDown(arr, 2);
            Print(arr, "\nDown to 2 rows:");

        }
    }
}
