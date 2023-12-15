using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zadanie
{
    internal class Program
    {
        public void Sum()
        {
            Console.WriteLine("Введите число");
            int N = int.Parse(Console.ReadLine());
         
            if (N % 2 == 0)
                Console.WriteLine("Число четное");

            else Console.WriteLine("Число нечетное");
            Console.ReadKey();
        }

        public void BlackJack()
        {
            Console.WriteLine("Введите количество карт");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите номинал каждой карты");
                string t = Console.ReadLine();
                switch (t) {
                    case "Q":
                        sum += 10;
                        break;
                    case "J":
                        sum += 10;
                        break;
                    case "K":
                        sum += 10;
                        break;
                    case "T":
                        sum += 10;
                        break;
                    default:
                        int c = Convert.ToInt32(t);
                        sum += c;
                        break;
                }

            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
        public void SimpleNumber()
        {
            Console.WriteLine("Введите число");
            int N = int.Parse(Console.ReadLine());
            bool n = false;
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    n = true;
                    break;
                }
            }
            if (n == true)
            {
                Console.WriteLine("Число не простое");
            }
            else Console.WriteLine("Число простое");
            Console.ReadKey();
        }

        public void MinValue()
        {
            Console.WriteLine("Введите длину последовательности");
            int N = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите число");
                int number = int.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine($"Минимальное число последовательности:{min}");
            Console.ReadKey();
        }

        public void GuessNumber()
        {
            Console.WriteLine("Введите число диапазона");
            int N = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int randomNumber = rnd.Next(N);
            while (true)
            {
                Console.WriteLine("Введите число");
                string t = Console.ReadLine();
                if (t == "")
                {
                    Console.WriteLine($"Загаданным число было{randomNumber}");
                    break;
                }
                int n = int.Parse(t);
                if (randomNumber > n)
                {
                    Console.WriteLine("Число больше");
                }
                else if(randomNumber < n)
                {
                    Console.WriteLine("Число меньше");
                }
                else if(randomNumber == n)
                {
                    Console.WriteLine("Вы угадали число:");
                    break;
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            
            Program program = new Program();
            //program.Sum();
            //program.BlackJack();
            //program.SimpleNumber();
            //program.MinValue();
            program.GuessNumber();
        }
    }
}
