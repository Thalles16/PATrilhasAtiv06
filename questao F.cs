using System;

class Program
{
     static void Main()
    {
        Console.WriteLine("insira uma sequencia de numeros inteiros");
        int quantidade = int.Parse(Console.ReadLine());

        int maiorNumero= int.MinValue;
        
        for(int i =0; i< quantidade; i++)
        {
        	
        	Console.WriteLine("digite um numero{0}", i + 1);
        	int numero = int.Parse(Console.ReadLine());
        
        
        
        if(numero > maiorNumero)
        {
        	
        	maiorNumero = numero;
        
        }
        }
        
        Console.WriteLine("oS NUM SÃo: {0}", maiorNumero);
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
