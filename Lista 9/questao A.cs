using System;

class Program
{
    static void Main()
    {

    	int[] numerais = {10,13,16,19,21};
    	
    	foreach (int numero in numerais)
    	{
    	Console.WriteLine("os valores do vetor sao: "+numero);
    	}
        
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
