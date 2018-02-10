using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tЛабораторная работа №1"
                + "\n\tКласс. Создание объекта. Работа с консолью."
                + "\n\t\t\tВыполнили:"
                + "\n\t\t\tСтуденты группы 16ВП1"
                + "\n\t\t\tБригады №2"
                + "\n\t\t\tМызгаев Денис"
                + "\n\t\t\tПодлеснов Ярослав");

            APS t = new APS("Наша станция", 12345, "ул. Рождественского, 51", 1100, 35.50, "Стандартный", 900);
            Console.WriteLine(t);

            int switch_on;
            bool continuing = true;
            while (continuing)
            {
                Console.WriteLine("\nВведите номер поля, которое желаете изменить. Введите '0', чтобы выйти. Введите '10', чтобы посмотреть");
                try
                {
                    switch_on = int.Parse(Console.ReadLine());
                    switch (switch_on)
                    {
                        case 1:
                            Console.WriteLine("Введите значение");
                            t.name = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Введите значение");
                            t.number = int.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Введите значение");
                            t.addres = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Введите значение");
                            t.countUsers = int.Parse(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Введите значение");
                            t.usersPay = double.Parse(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Введите значение");
                            t.tarif = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Введите значение");
                            t.freeLines = int.Parse(Console.ReadLine());
                            break;
                        case 0:
                            continuing = false;
                            break;
                        case 10:
                            Console.WriteLine(t);
                            break;
                        default:
                            throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите число правильно!");
                    continue;
                }
            }
            Console.WriteLine();
            t.printNumber16();
        }
    }
}
