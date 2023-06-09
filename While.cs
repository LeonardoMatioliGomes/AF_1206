using System;

//declarado a classe "program" 
class Program
{
    
    //no método "Main" declaramos duas variaveis: "num" (que armazena o numero fornecido pelo usuario) e "i" (que será usado como contador para iterar de 1 até o numero frnecido)
    static void Main(string[] args)
    {
        int num, i = 1;
        
	//será mostrado ao usuario a mensagem:
        Console.Write("Digite um numero inteiro positivo: ");

	//le a entrada do usuario como uma string, e converte essa string em um numero inteiro
        num = int.Parse(Console.ReadLine());
        
	//Isso garante que o laço seja executado exatamente "num" vezes
        while (i <= num)
        {
	    //Isso exibe cada número inteiro de 1 a "num" na saída padrão
            Console.Write(i + " ");
            i++;
        }
	
	// para pausar a execução do programa até que o usuário pressione Enter. Isso permite que o usuário veja os resultados antes que o programa termine
        Console.ReadLine();
    }
}