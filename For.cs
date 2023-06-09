using System;

class Program {
    static void Main() {
        int num;
        // interface para o usuário inserir valores inteiros e positivos
        Console.Write("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());
        // interface da resposta
        Console.Write("Os primeiros " + num + " números pares são: ");
        // for faz a inicialização, condição e atualização
        for (int i = 2; i <= num * 2; i += 2) {
            Console.Write(i + " ");
        }
    }
}