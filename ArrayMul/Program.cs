﻿using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 6)
            {
                Console.WriteLine(" ");
            }

            float arg1 = float.Parse(args[0]);
            float arg2 = float.Parse(args[1]);
            float arg3 = float.Parse(args[2]);
            float arg4 = float.Parse(args[3]);
            float arg5 = float.Parse(args[4]);
            float arg6 = float.Parse(args[5]);

            float[,] A = new float[2, 2] { { arg1, arg2}, { arg3, arg4 } };
            float[] b = new float[2] { arg5, arg6 };

            float[] result = new float[2];

            for (int i = 0; i < 2; i++)
            {
                result[i] = 0;
                for (int j = 0; j < 2; j++)
                {
                    result[i] += A[i, j] * b[j];
                }
            }

            Console.WriteLine("A =");
            Console.WriteLine($"| {arg1,7:F2} {arg2,7:F2} |");
            Console.WriteLine($"| {arg3,7:F2} {arg4,7:F2} |");

            Console.WriteLine("\nb =");
            Console.WriteLine($"| {arg5,7:F2} |");
            Console.WriteLine($"| {arg6,7:F2} |");

            Console.WriteLine("\nA . b =");
            Console.WriteLine($"| {result[0],7:F2} |");
            Console.WriteLine($"| {result[1],7:F2} |");
        }
    }
}
