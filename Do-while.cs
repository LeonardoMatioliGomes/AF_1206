using System;

//a classe "program" é a classe principal do programa.
class Program
{
    //"main" é onde a execução do programa começa
    static void Main(string[] args)
    {
	//declara uma variável inteira chamad a "num", que será armazenada.
        int num;
        
	//aqui é onde a repetoção "do-while" começa
        do

	//Entre as chaves { } o código será executado pelo menos uma vez, e continuará a ser repetido enquanto a condição num < 1 || num > 10 for verdadeira
        {

//lê a entrada do usuário como uma string. A função "Convert.ToInt32" é usada para converter essa string em um número inteiro e atribuí-lo à variável "num"
            Console.Write("Digite um número entre 1 e 10: ");
            num = Convert.ToInt32(Console.ReadLine());
        } while (num < 1 || num > 10);
        
	//exibe a mensagem com o numero que voce colocou
        Console.WriteLine("Você digitou o número " + num + ".");
    }
}