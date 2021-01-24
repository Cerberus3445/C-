#region Автор
//Егор Малов
#endregion

#region Описание задачи
//Ввести вес и рост человека.
#endregion


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш рост");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ваш вес");
            var b = Convert.ToInt32(Console.ReadLine());

            var sum = a + b;

            Console.WriteLine($"Вы прошли анкету");

            Console.ReadLine();

        }
    }
}
