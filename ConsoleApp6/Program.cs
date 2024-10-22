using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.
            //try
            //{
            //    Console.WriteLine("Введите номер недели:");
            //    int n = int.Parse(Console.ReadLine());
            //    switch (n)
            //        {
            //        case 1:Console.WriteLine("Понедельник");
            //            break;
            //        case 2:Console.WriteLine("Вторник");
            //            break;
            //        case 3: Console.WriteLine("Среда");
            //            break;
            //        case 4:Console.WriteLine("Четверг");
            //            break;
            //        case 5: Console.WriteLine("Пятница");
            //            break;
            //        case 6: Console.WriteLine("Суббота");
            //            break;
            //        case 7:Console.WriteLine("Воскресенье");
            //            break;
            //        default: Console.WriteLine("Выберите от 1 до 7");
            //            break;

            //    }

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Исключение:{ex.Message}");
            //}
            //Console.ReadKey();

            //Задание 2  По номеру месяца вывести название времени года.
            //try
            //{
            //    Console.WriteLine("Введите номер месяца");
            //    int n = int.Parse(Console.ReadLine());
            //    switch (n)
            //    {
            //        case 1:
            //            Console.WriteLine("Январь");
            //            break;
            //        case 2:
            //            Console.WriteLine("Февраль");
            //            break;
            //        case 3:
            //            Console.WriteLine("Апрель");
            //            break;
            //        case 4:
            //            Console.WriteLine("Март");
            //            break;
            //        case 5:
            //            Console.WriteLine("Май");
            //            break;
            //        case 6:
            //            Console.WriteLine("Июнь");
            //            break;
            //        case 7:
            //            Console.WriteLine("Июль");
            //            break;
            //        case 8:
            //            Console.WriteLine("Август");
            //            break;
            //        case 9:
            //            Console.WriteLine("Сентябрь");
            //            break;
            //        case 10:
            //            Console.WriteLine("Октябрь");
            //            break;
            //        case 11:
            //            Console.WriteLine("Ноябрь");
            //            break;
            //        case 12:
            //            Console.WriteLine("Январь");
            //            break;
            //        default:
            //            Console.WriteLine("Введите от 1 до 12");
            //            break;

            //    }
            //}
            //catch (Exception ex)
            //{ Console.WriteLine($"Исключение:{ex.Message}");
            //}
            //Console.ReadKey();

            //Задание 3 Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд.
            //Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
            //try
            //{
            //    Console.WriteLine("Введите т/с");
            //    string ts = Console.ReadLine();
            //    switch (ts)
            //    {
            //        case "a":
            //            Console.WriteLine("Автомобиль 200");
            //            break;
            //        case "b":
            //            Console.WriteLine("Велосипед 20");
            //            break;
            //        case "m":
            //            Console.WriteLine("Мотоцикл 60");
            //            break;
            //        case "c":
            //            Console.WriteLine("Самолет 500");
            //            break;
            //        case "p":
            //            Console.WriteLine("Поезд 150");
            //            break;
            //        default:
            //            Console.WriteLine("Введите a-b-m-c-p");
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Исключение:{ex.Message}");
            //}
            //Console.ReadKey();

            // Задача 4. Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.
            //try
            //{
            //    Console.WriteLine("Название предмета");
            //    char n = char.Parse(Console.ReadLine());
            //    switch(n)
            //    {
            //        case 'ф':Console.WriteLine("Физика");
            //            break;
            //        case 'м':Console.WriteLine("Математика");
            //            break;
            //        case 'и':Console.WriteLine("История");
            //            break;
            //        case 'г':Console.WriteLine("География");
            //            break;
            //        case 'б':Console.WriteLine("Биология");
            //            break;
            //        default:Console.WriteLine("Выберите ф-м-и-г-б");
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Исключение:{ex.Message}");
            //}
            //Console.ReadKey();

            // Задание 5. Проведен тест, оцениваемый в целочисленных баллах от нуля до ста. Вывести на экран оценку тестируемого в зависимости от набранного кол-ва баллов: 
            // от 90 до 100 - <<отлично>>, от 70 до 89 - <<Хорошо>>, от 50 до 69 - <<Удовлетворительно>>, менее 50 <<Неудовлетворительно>>
            try
            {
                Console.WriteLine("Введите свой балл от 0 до 100:");
                int bal = int.Parse(Console.ReadLine());
                switch (bal)
                {
                    case int w when (bal >= 90 && bal <= 100):Console.WriteLine("Оценка отлично");
                        break;
                    case int w when (bal >= 70 && bal <= 89):Console.WriteLine("Хорошо");
                        break;
                    case int w when (bal >= 50 && bal <= 69):Console.WriteLine("Удовлетворительно");
                        break;
                    case int w when (bal <= 49):Console.WriteLine("Неудовлетворительно");
                        break;
                    default:Console.WriteLine("Введите балл от 0 до 100");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение:{ex.Message}");
            }
            Console.ReadKey();
        }
       
    }
}
