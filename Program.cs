using System;
using System.Diagnostics;

namespace Calculadora
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

            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("1 - Soma");
            System.Console.WriteLine("2 - Subtracao");
            System.Console.WriteLine("3 - Divisao");
            System.Console.WriteLine("4 - Multiplicacao");
            System.Console.WriteLine("5 - Sair");
            System.Console.WriteLine("------------------------");
            Console.Write("Selecione uma opcao: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            System.Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine();

            double resultado = v1 + v2;
            System.Console.WriteLine($"O resultado da soma eh: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            System.Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine();

            double resultado = v1 - v2;
            System.Console.WriteLine($"O resultado da subtracao eh: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            System.Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine();

            double resultado = v1 / v2;
            System.Console.WriteLine($"O resultado da divisao eh: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            System.Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine();

            double resultado = v1 * v2;
            System.Console.WriteLine($"O resultado da multiplicacao eh: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
