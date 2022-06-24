using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nameCount = 0;
            int nameLength = 0;
            
            Console.Write("Pls input the names count: ");
            nameCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pls input the names length: ");
            nameLength = Convert.ToInt32(Console.ReadLine());
            
            char[,] name2 = new char[nameCount, nameLength];
            string[] name3 = new string[nameCount];
            for (int i = 0; i < nameCount; i++)
            {
                Console.WriteLine("Pls input name");
                name3[i] = Console.ReadLine();
            }
            
            for (int i = 0; i < nameCount; i++)
            {
                for (int j = 0; j < nameLength; j++)
                {
                    name2[i, j] = name3[i][j];
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < nameCount; i++)
            {
                for (int j = 0; j < nameLength; j++)
                {
                    Console.Write($"{name2[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
