using System;

class Program
{
    //código define as funções (métodos) que realizam as operações matemáticas. Cada método recebe dois números ("a" e "b") e retorna o resultado da operação correspondente. A função "Dividir" também inclui uma verificação para evitar a divisão por zero, exibindo uma mensagem de erro caso o divisor seja zero.
    static double Somar(double a, double b)
    {
        return a + b;
    }

    static double Subtrair(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Erro: divisão por zero!");
            return 0;
        }
        else
        {
            return a / b;
        }
    }
    
    //método "Main", que é o ponto de entrada do programa. Ele define duas variáveis "x" e "y" com os valores 4 e 8
    static void Main(string[] args)
    {
        double x = 4;
        double y = 8;
        
        //feita a soma de "x" e "y"
        double resultado = Somar(x, y);
        Console.WriteLine(x + " + " + y + " = " + resultado);

        //feita a subtração de "x" e "y"
        resultado = Subtrair(x, y);
        Console.WriteLine(x + " - " + y + " = " + resultado);

        //feita a multiplicação de "x" e "y"
        resultado = Multiplicar(x, y);
        Console.WriteLine(x + " * " + y + " = " + resultado);

        //feita a divisão de "x" e "y"
        resultado = Dividir(x, y);
        Console.WriteLine(x + " / " + y + " = " + resultado);

        //imprime o código
        Console.ReadKey();
    }
}
