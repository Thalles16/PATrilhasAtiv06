using System;

class Program
{
    public static void Main()
    {
        // Solicita ao usuário para inserir um número inteiro
        Console.WriteLine("Digite um número inteiro para verificar se é primo:");
        int num = int.Parse(Console.ReadLine());

        // Verifica se o número é primo
        if (num <= 1)
        {
            Console.WriteLine(num + " não é um número primo.");
        }
        else
        {
            bool isPrimo = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)  // Se o número for divisível por i
                {
                    isPrimo = false;
                    break;
                }
            }

            // Exibe o resultado final
            if (isPrimo)
                Console.WriteLine(num + " é um número primo.");
            else
                Console.WriteLine(num + " não é um número primo.");
        }

        // Espera que o usuário aperte uma tecla para fechar o programa
        Console.WriteLine("APERTE QUALQUER COISA PARA FECHAR");
        Console.ReadKey(true);
    }
}
