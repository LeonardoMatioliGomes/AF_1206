using System;

//Essa parte do código define a classe "Program", que é a classe principal do programa. Dentro dela, temos o método "Main", que é o ponto de entrada do programa.
class Program {
    static void Main() {
        int num;
        
        // interface para o usuário inserir valores inteiros e positivos
        Console.Write("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());
        
        //"Console.Write" é usado para mostrar a mensagem
        Console.Write("Os primeiros " + num + " números pares são: ");
        
        // temos um loop "for" que começa com "i" igual a 2, verifica se "i" é menor ou igual ao dobro do valor digitado (num * 2), e incrementa "i" em 2 a cada iteração
        for (int i = 2; i <= num * 2; i += 2) {
            //usado "console.write" para exibir cada número par (i) seguido de um espaço em branco
            Console.Write(i + " ");
        }
    }
}
