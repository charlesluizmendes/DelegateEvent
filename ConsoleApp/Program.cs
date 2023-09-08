using ConsoleApp.Classes;
using System;
using static ConsoleApp.Classes.Button;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate

            Console.WriteLine("============ Delegate ===============");
            Console.WriteLine();

            Calculator calculator = new Calculator();
            calculator.operation = Addition;
            calculator.operation += Subtraction;
            calculator.operation += Multiplication;
            calculator.operation += Division;
            calculator.RealizarOperacao(25, 5);

            #endregion

            #region Event

            Console.WriteLine();
            Console.WriteLine("============= Event =================");
            Console.WriteLine();

            Button button = new Button();
            button.Click += new ButtonEventHandler(Handle); // Associa o delegate a um método
            button.SimularClick(); // Simula um clique no botão

            #endregion

            Console.ReadKey();
        }

        #region Delegate Methods

        public static double Addition(double a, double b)
        {
            Console.WriteLine("O Resultado da Soma: " + (a + b));

            return a + b;
        }

        public static double Subtraction(double a, double b)
        {
            Console.WriteLine("O Resultado da Subtracao: " + (a - b));

            return a - b;
        }

        public static double Multiplication(double a, double b)
        {
            Console.WriteLine("O Resultado da Multiplicacao: " + (a * b));

            return a * b;
        }

        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero!");

                return 0;
            }

            Console.WriteLine("O Resultado da Divisao: " + (a / b));

            return a / b;
        }

        #endregion

        #region Event Methods

        private static void Handle()
        {
            Console.WriteLine("Manipulador de Evento Executado");
        }

        #endregion
    }
}
