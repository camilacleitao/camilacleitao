using System;

namespace CalculadoraCompleta
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0;

            double numero1, numero2, soma, subtracao;


            //lend numero 1
            Console.WriteLine("Digite primeiro numero: ");

            numero1 = int.Parse(Console.ReadLine());


            //Lendo numero2
            Console.WriteLine("Digite segundo numero: ");

            numero2 = int.Parse(Console.ReadLine());


            Console.WriteLine("|=====================================|");
            Console.WriteLine("     Calculadora Cris S.A       |");
            Console.WriteLine("|                 Menu                |");
            Console.WriteLine("|                                     |");
            Console.WriteLine("| 1 - Somar                           |");
            Console.WriteLine("| 2 - Subtrair                        |");
            Console.WriteLine("| 3 - Multiplicar                     |");
            Console.WriteLine("| 4 - Dividir                         |");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|=====================================|" + "\n");

            Console.WriteLine("Digite a opção de 1 a 4: ");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if (opcao == 1)
            {

                soma = numero1 + numero2;
                Console.WriteLine("Soma: " + soma);

            }
            else
            {
                subtracao = numero1 - numero2;
                Console.WriteLine("Soma: " + subtracao);


            }
            Console.ReadKey();
        }

    }
}

  

