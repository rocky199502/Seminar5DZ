using System;
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
namespace DZ3
{
    class Program
    {
        static double[] randMass(int size)
        {
            double[] mass = new double[size];
            Random rand = new Random();
            for (int i =0; i<mass.Length; i++)
            {
                mass[i]=rand.Next(0,99)/10.0;
                }
            return mass;
            }
        static double maxMinSub(double[] mass)
        {
            double max = mass[0];
            double min = mass[0];
            for (int i = 0; i<mass.Length; i++)
            {
                if (mass[i]>max)
                {
                    max = mass[i];
                }
                if (mass[i]<min)
                {
                    min = mass[i];
                }
            } 
            double substr = max - min ;
            return substr;
        }
        static void Main(string[] args)
        {
           int size = 5;
           double[] mass = randMass(size);
           for (int i =0; i<mass.Length; i++)
           {
            Console.Write(mass[i]+"   ");
            }
            double substr = maxMinSub(mass);
            Console.WriteLine(" ");
            Console.WriteLine("Разница между max и min: "+ substr);
        }
    }
}
