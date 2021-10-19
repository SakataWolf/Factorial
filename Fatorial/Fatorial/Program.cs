using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nFatorial");
            double resultado = 1;
            int numero;
            Console.Write("\n\nDigite um número: ");
            numero = int.Parse(Console.ReadLine());
            while (numero != 1)
            {
                resultado = resultado * numero;
                numero = numero - 1;
            }
            Console.WriteLine("\n\nO fatorial do número escolhido é "+resultado);
        }
    }
}
