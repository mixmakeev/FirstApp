﻿using System; // Подключенное пространство имен
using System.Text;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1251 = Encoding.GetEncoding(1251);

            System.Console.OutputEncoding = System.Text.Encoding.UTF8; //Для вывода юникода в консоли, иначе ничего не выводит.
            System.Console.InputEncoding = enc1251;
            Console.WriteLine("Как Вас зовут?"); // Задать вопрос
            var name = Console.ReadLine(); // Запрос имени, запись в переменную name
            Console.WriteLine("Здравствуйте, {0}, сколько Вам лет?", name);
            int age = Convert.ToInt32(Console.ReadLine()); //Запрос возраста, запись в переменную age
            Console.WriteLine("{0}, Какой у Вас размер обуви?", name);
            double MyShoeSize = Convert.ToDouble(Console.ReadLine()); // Запрос имени, запись в переменную name      
            Console.WriteLine("Хорошо, {0}, а как называется Ваша должность?", name);
            var work = Console.ReadLine(); //Запрос должности, запись в переменную work
            Console.WriteLine("\t{0}, \n\tя записал, что Вам {1} \n\tи Вы работаете на должности {2}\nразмер обуви {3}", name, age, work, MyShoeSize);
        }
    }
}