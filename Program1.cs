#region Автор
// Егор Малов
#endregion

#region Описание задачи
// Написать программу обмена значениями двух переменных.
//а) с использованием третьей переменной;
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 3;
            int c = 4;
            int temp = a;
            a = b;
            c = a;
            b = temp;
            a = temp;

            Console.WriteLine($"{a}, {b}, {c}");

            Console.ReadLine();
        }
    }
}
