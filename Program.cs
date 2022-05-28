using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subtracao();

        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor da soma: ");
            float soma1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor da soma: ");
            float soma2 = float.Parse(Console.ReadLine());

            float result = soma1 + soma2;

            Console.WriteLine(" ");

            Console.WriteLine("O resultado da soma é: " + result);

            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor da subtração: ");
            float subtracao1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor da subtração: ");
            float subtracao2 = float.Parse((string)Console.ReadLine());

            float subresult = subtracao1 - subtracao2;

            Console.WriteLine(" ");

            Console.WriteLine("O resultado da subtração é: "+ subresult);

            Console.ReadKey();
              
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor da divisão: ");
            float divisao1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor da divisão: ");
            float divisao2 = float.Parse(Console.ReadLine());

            float divResult = divisao1 / divisao2;

            Console.WriteLine(" ");

            Console.WriteLine("O resultado da divisão é: " + divResult);

            Console.ReadKey();


        }
        
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor da multiplicação");
            float multiplicacao1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor da multiplicação");
            float multiplicacao2 = float.Parse(Console.ReadLine());

            float multiResult = multiplicacao1 * multiplicacao2;

            Console.WriteLine(" ");

            Console.WriteLine("O resultado da multiplicação é: "+ multiResult);

            Console.ReadKey();


        }

    }
}
