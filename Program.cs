﻿using System;

namespace ArrayReverse{

    class Program{
        static void Main(string[] args){

        int[] array = { 1, 2, 3,4,5,6,7,8,9,10 };
        foreach (int a in array)
        {
            Console.WriteLine(a);
        }

        Array.Reverse(array);
        Console.WriteLine("Reversed Array : ");
        foreach (int value in array)
        {
            Console.WriteLine(value);
        }
        Console.ReadLine();


        }
    }
}
