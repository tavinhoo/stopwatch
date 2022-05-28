using System;
using System.Threading;

namespace Cronômetro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");

            Console.WriteLine("Quanto tempo deseja contar?");
            string data = Console.ReadLine().ToLower();
            // char type = data[data.Length - 1];
            // Console.WriteLine(data[data.Length - 1]);
            if (data == "0")
            {
                System.Environment.Exit(0);
            };

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            switch (type)
            {
                case 's':
                    PreStart(time);
                    break;
                case 'm':
                    time *= 60;
                    PreStart(time);
                    break;
                default:
                    Console.WriteLine("ERRO");
                    break;
            }

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!!!");
            Thread.Sleep(500);
            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;
            // faz a contagem de forma totalmente síncrona
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                // faz a execução "dormir" por x segundos antes do prox. passo
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finished.... returning to the menu");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
