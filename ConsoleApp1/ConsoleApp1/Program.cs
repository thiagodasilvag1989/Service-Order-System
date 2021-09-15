using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 7;
            double valor2 = -5;
            double valor3 = 6;
            double valor4 = -3.4;
            double valor5 = 4.6;
            double valor6 = 12;

            int ehPositivo = 0;

            double[] todosValores = { valor1, valor2, valor3, valor4, valor5, valor6 };
            for (int i = 0; i < todosValores.Length; i++)
            {
                if (todosValores[i] > 0.0)
                {
                    ehPositivo += 1;
                }
            }
            //comtinue com sua solução

            Console.WriteLine(ehPositivo + " valores positivos");
        }

    }
}


