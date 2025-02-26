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
            int a = mas[0];
            int max = 0;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                    if (a < mas[i])
                    {
                        a = mas[i];
                        max = i;
                    }
            }
            Console.WriteLine($"\nmax = mas[{max}]");

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
        int[] mas = new int[5] {2,4,3,6,8};

        for (int i = 0; i < mas.Length; i++)
        {  
                Console.WriteLine($"mas[{i}] = {mas[i]}");
        }
        PrintMas(mas);
        Sort(mas);
    }

    static void Main(string[] args)
    {
        Mas();

        Console.Read();
    }
}
}
