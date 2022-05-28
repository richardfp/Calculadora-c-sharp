using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione uma opção: ");

            short cons = short.Parse(Console.ReadLine());

            switch(cons)
            {
              case 1: Soma();break;
              case 2: Subtracao();break;
              case 3: Divisao(); break;
              case 4: Multiplicacao(); break;
              case 5: System.Environment.Exit(0);break;
              default: Menu(); break;

            }
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

            Menu();
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

            Menu();
              
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

            Menu();


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

            Menu();


        }

 

    }
}
