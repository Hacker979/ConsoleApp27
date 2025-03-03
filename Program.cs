using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Sort(int[] mas)
        {
            int razn = 0;
            int temp = 0;
            int a = mas[0];
            int b = mas[0];
            int max = 0;
            int min = 0;
            for (int i = 1; i < mas.Length; i++)
            {
                if (a < mas[i])
                {
                    a = mas[i];
                    max = i;
                }
                if (b > mas[i])
                {
                    b = mas[i];
                    min = i;
                }
            }

            razn = max - min;

            Console.WriteLine($"\nmax: mas[{max}] = {mas[max]}");
            Console.WriteLine($"min: mas[{min}] = {mas[min]}");
            Console.WriteLine($"количество элементов между максимальным и минимальным элементами = {razn}");

            temp = mas[max];
            mas[max] = mas[min];
            mas[min] = temp;


        }
        static void PrintMas(int[] mas)
        {
            foreach (int i in mas)
            {
                Console.Write(i + " ");
            }
        }
        static void Mas()
        {
            int[] mas = new int[5];
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"mas[{i}] = ");
                mas[i] = int.Parse(Console.ReadLine());
            }

            Sort(mas);
            Console.Write("\nпоменять местами максимальный и минимальный элементы, вывести одномерный массив: ");
            PrintMas(mas);
        }
    
        static void Main(string[] args)
        {
            Mas();

            Console.Read();
        }
    }
}
