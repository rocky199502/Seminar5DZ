using System;
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
namespace DZ2
{
    class Program
    {
        static int[] randMass(int size)
        {
            int[] mass = new int[size];
            Random rand = new Random();
            for (int i =0; i<mass.Length; i++)
            {
                mass[i]=rand.Next(-99,99);
            }
            return mass;
        }
        static int sumNechet(int[] mass)
        {
            int sum = 0;
            for (int i = 0; i<mass.Length; i++)
            {
                if (i%2 != 0)
                {
                    sum+=mass[i];
                }
            } 
            return sum;
        }
        static void Main(string[] args)
        {
            int size = 4;
            int[] mass = randMass(size);
            for (int i =0; i<mass.Length; i++)
            {
                Console.Write(mass[i]+" ");
            }
            int sum = sumNechet(mass);
            Console.WriteLine(" ");
            Console.WriteLine("Сумма нечетных позиций в массиве: "+ sum);
        }
    }
}
