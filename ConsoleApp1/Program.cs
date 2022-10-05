using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу \"Проверочная работа 2\"");
            Console.WriteLine("Выберите программу: ");
            Console.WriteLine("1) Таблица умножения");
            Console.WriteLine("2) Игра \"Угадай число\"");
            Console.WriteLine("3) Вывод делителей числа");
            Console.WriteLine("4) Выход из программы");
            while (true)
            {
                int programma = Convert.ToInt32(Console.ReadLine());

                if (programma <= 0 || programma > 4)
                {
                    Console.WriteLine("Ошибка.Вы выбрали неверную программу!");
                }

                switch (programma)
                {
                    case 1:
                        Tablica(args);
                        break;
                    case 2:
                        UgadaiChislo(args);
                        break;
                    case 3:
                        VivodDelitelei(args);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("\r\nВыберите программу: ");
                Console.WriteLine("1) Таблица умножения");
                Console.WriteLine("2) Игра \"Угадай число\"");
                Console.WriteLine("3) Вывод делителей числа");
                Console.WriteLine("4) Выход из программы");
            }
        }
        static void Tablica(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу \"Таблица умножения\"");
            int[,] tablica = new int[10, 10];
            int mn1 = 1;
            int mn2 = 1;
            while (mn1 < tablica.GetLength(0) || mn2 < tablica.GetLength(1))
            {
                tablica[mn1, mn2] = mn1 * mn2;
                if (mn1 * mn2 >= 10)
                {
                    Console.Write(tablica[mn1, mn2] + " ");
                }
                else
                {
                    Console.Write(tablica[mn1, mn2] + " " + " ");
                }
                mn2++;
                if (mn2 == tablica.GetLength(1))
                {
                    mn1++;
                    mn2 = 1;
                    Console.WriteLine(" ");
                }
                if (mn1 > 9 || mn2 > 9)
                {
                    break;
                }
            }
        }
        static void UgadaiChislo(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру \"Угадай число\"");
            Console.WriteLine("Попробуй отгадать число от 0 до 100! ");
            Random rnd = new Random();
            int random = rnd.Next(0, 100);
            int chislo = 0;
            int attempts = 0;
            if (chislo > 100 || chislo < 0)
            {
                Console.WriteLine("Число должно быть от 0 до 100!");
            }
            while (chislo != random)
            {
                chislo = Convert.ToInt32(Console.ReadLine());
                if (chislo > random)
                {
                    Console.WriteLine("Попробуй меньше");
                    attempts++;
                }
                if (chislo < random)
                {
                    Console.WriteLine("Попробуй больше");
                    attempts++;
                }
            }
            Console.WriteLine("Молодец!Ты угадал число!");
            attempts++;
            Console.WriteLine("Число попыток: " + attempts);
            return;
        }

        static void VivodDelitelei(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу \"Вывод делителей числа\"");
            Console.WriteLine("Введите число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());

            for (int del = 1; del <= chislo; del++)
            {
                if (chislo % del == 0)
                {
                    Console.Write(del + " ");
                }
            }
        }
    }
}
