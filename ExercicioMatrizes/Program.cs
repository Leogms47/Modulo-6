﻿using System;
using System.Runtime.Intrinsics.Arm;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Quantas linhas e colunas você deseja para a Matriz? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Digite os dados da ");
        }
    }
}
