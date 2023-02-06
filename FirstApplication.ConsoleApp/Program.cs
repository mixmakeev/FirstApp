using System; // Подключенное пространство имен
using System.Text;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); //Решение проблемы с отображением кирилицы 
            var enc1251 = Encoding.GetEncoding(1251);
            System.Console.OutputEncoding = System.Text.Encoding.UTF8; 
            System.Console.InputEncoding = enc1251;

            // Запрос имени, запись в переменную name
                        Console.WriteLine("Как Вас зовут?"); 
            var name = Console.ReadLine();
            //Запрос возраста, запись в переменную age. Конвертация в byte, проверка на преобразование без потери данных
                        Console.WriteLine($"Здравствуйте, {name}, сколько Вам лет?");
                        byte age = checked((byte)int.Parse(Console.ReadLine()));
            // Запрос размера обуви, запись в переменную MyShoeSize 
                        Console.WriteLine($"{name}, Какой у Вас размер обуви?");
            double MyShoeSize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{name}, Какой у Вас любимый день недели (1-7)?");
            DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
            //Запрос должности, запись в переменную work
            Console.WriteLine($"Хорошо, {name}, а как называется Ваша должность?");
            var work = Console.ReadLine(); 
            Console.WriteLine($"\t{name}, \n\tВам {age} \n\tВы работаете на должности {work}\n\tВаш любимый день недели {day}\n\tразмер обуви {MyShoeSize}");
        }
    }
}