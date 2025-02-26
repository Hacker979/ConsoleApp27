using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int[] Sort(int[] mas)
        {
            int a = 0;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                    if (mas[i] > mas[j])
                    {
                        a = mas[i];
                        mas[i] = mas[j];
                        mas[j] = a;
                    }
            }
            return mas;
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
        Random rand = new Random();
        for (int i = 0; i < mas.Length; i++)
        {  
                mas[i] = rand.Next(-100, 100);
                Console.WriteLine($"mas[{i}] = {mas[i]}");
        }
        PrintMas(Sort(mas));
    }

    static void Main(string[] args)
    {
        Mas();

        Console.Read();
    }
}
}
