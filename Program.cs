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
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

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
        }
    }
}
