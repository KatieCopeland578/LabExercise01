﻿using System;
using System.IO;

namespace LabExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("input.txt"))
            {
                Console.WriteLine("File exists.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }

            Console.ReadKey();
        }
    }
}
