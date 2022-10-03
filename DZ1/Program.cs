using System;
//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

namespace DZ1
{
    class Program
    {
        static int[] randMass(int size)
        {
            int[] mass = new int[size];
            Random rand = new Random();
            for (int i =0; i<mass.Length; i++)
            {
                mass[i]=rand.Next(100,999);
            }
            return mass;
        }
        static int kolChet(int[] mass)
        {
            int kol = 0;
            for (int i = 0; i<mass.Length; i++)
            {
                if (mass[i]%2 == 0)
                {
                    kol++;
                }
            } 
            return kol;
        }
        static void Main(string[] args)
        {
           int size = 4;
           int[] mass = randMass(size);
           for (int i =0; i<mass.Length; i++)
           {
            Console.Write(mass[i]+" ");
           }
           int chetNumber = kolChet(mass);
           Console.WriteLine(" ");
           Console.WriteLine("Количество четных чисел в массиве: "+ chetNumber);
        }
    }
}
