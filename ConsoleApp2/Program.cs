using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program : Person
    {
        private static void Main(string[] args)
        {
            var newPerson = new Person("Misha", 32, "Moscow");
            print(newPerson.Name);
            print(newPerson.Age);
            print(newPerson.Address);

            Randomaizer();
            RndList();
        }

        private static void Write1()
        {
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }

        private static void calc()
        {
            int num1, num2, age;
            print("введите первое число");
            num1 = ReadLine();

            print("\nВведите второе число");
            num2 = ReadLine();

            print($"\nСумма двух сисел равна: {num1 + num2}");

            print("Введите свой возраст");
            age = ReadLine();

            if (age < 18)
            {
                print("Вы несовершеннолетний");
            }

            else if (18 <= age && age < 20)

            {
                print("Вам больше 18ти и меньше 20");
            }

            else
            {
                print("Вы старый пердун");
            }

            Console.ReadKey(true);
        }

        private static int ReadLine()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void print(object text) => Console.WriteLine(text);


        private static void Randomaizer()
        {
            var rndNum = new Random();
            var num = rndNum.Next(1, 30);
            print(num);
            print(num % 2 == 0 ? "Четное" : "Нечетное");

            for (var i = 0; i < num; i++)
            {
                print("Привет");
            }

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                var num1 = rndNum.Next(1, 30);
                array[i] = num1;
            }

            foreach (var t in array)
            {
                print(t);
            }
        }

        private static void RndList()
        {
            List<int> myList = new List<int>();
            var rndNum = new Random();

            for (int i = 0; i < 20; i++)
            {
                myList.Add(rndNum.Next(1, 30));
            }

            foreach (var t in myList)
            {
                print(t);
            }
        }
    }
}