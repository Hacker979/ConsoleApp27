using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int[] Reverse(int[] mas)
        {
            int b = 0;
            int[] Newmas = new int[mas.Length];
            for (int i = mas.Length - 1; i >= 0; i--)

            {
                Newmas[b] = mas[i];
                b++;
            }
            return Newmas;
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
            PrintMas(Reverse(mas));
        }

        static void Main(string[] args)
        {
            Mas();

            Console.Read();
        }
    }
}
