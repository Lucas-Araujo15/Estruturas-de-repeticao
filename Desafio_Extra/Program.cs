using System;

namespace Desafio_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroanterior = 0;
            int numeroatual = 1;
            int fibonacci;

            Console.WriteLine(numeroanterior);
            Console.WriteLine(numeroatual);

            do
            {
                fibonacci = numeroatual + numeroanterior;
                Console.WriteLine(fibonacci);
                numeroanterior = numeroatual;
                numeroatual = fibonacci;

            }while(fibonacci <= 500);
                
        }

    }
    
}
