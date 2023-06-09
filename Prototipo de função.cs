using System;

class Program
{
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

    static void Main(string[] args)
    {
        double x = 4;
        double y = 8;

        double resultado = Somar(x, y);
        Console.WriteLine(x + " + " + y + " = " + resultado);

        resultado = Subtrair(x, y);
        Console.WriteLine(x + " - " + y + " = " + resultado);

        resultado = Multiplicar(x, y);
        Console.WriteLine(x + " * " + y + " = " + resultado);

        resultado = Dividir(x, y);
        Console.WriteLine(x + " / " + y + " = " + resultado);

        //imprime o código
        Console.ReadKey();
    }
}