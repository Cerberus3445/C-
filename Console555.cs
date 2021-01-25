#region Автор
//Малов Егор
#endregion

#region Описание задачи
//Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Анкета в военкомат");
            Console.WriteLine("Введите ваше имя");
            string myname;
            myname = Console.ReadLine();
            Console.WriteLine("Следующий вопрос" +  myname);
            Console.WriteLine("Введите вашу фамилию");
            string surname;
            surname = Console.ReadLine();
            Console.WriteLine("Следующий вопрос" +  surname);
            Console.WriteLine("Введите ваш возраст");
            string age;
            age = Console.ReadLine();
            Console.WriteLine("Следующий вопрос" +  surname);
            Console.WriteLine("Введите ваш рост");
            string growth;
            growth = Console.ReadLine();
            Console.WriteLine("Следующий вопрос" + surname);
            Console.WriteLine("Введите ваш вес");
            string weight;
            weight = Console.ReadLine();
            Console.WriteLine($"Спасибо, что прошли анкету"); 
            Console.ReadLine();
        }
    }
}
