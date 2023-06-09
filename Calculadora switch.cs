using System;

//usado para agrupar o código relacionado à calculadora em um escopo separado
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
	    //responsavel por executar os cálculos
            Calculator calculator = new Calculator();

	    //usada para armazenar a resposta do usuário sobre se deseja fazer outro cálculo ou não
            char resposta;
	    //Em um loop "do-while", o programa solicita ao usuário os números e o operador para realizar o cálculo. Os valores são lidos usando "Console.ReadLine()" e convertidos para "double" usando "double.Parse()"
            do
            {
                double num1, num2, resultado;
                char operador;

		//frases que vão aparecer ao usuario para realizar os calculos
                Console.Write("Entre com o primeiro valor: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Entre com o operador (+, -, *, /): ");
                operador = char.Parse(Console.ReadLine());

                Console.Write("Entre com o segundo valor: ");
                num2 = double.Parse(Console.ReadLine());

                resultado = calculator.Calculate(num1, num2, operador);
		
                if (double.IsNaN(resultado))
                {
		    //caso faça uma divisão por "0", o program irá avisar
                    Console.WriteLine("Erro: divisão por zero!");
                }
                else
                {

                    Console.WriteLine("O resultado é: " + resultado);
                }

	        //é perguntado se o usuario quer continuar a usar a calculadora
                Console.Write("Deseja fazer outro cálculo? (S/N): ");
                resposta = char.Parse(Console.ReadLine());
                Console.WriteLine();

            } while (resposta == 's' || resposta == 'S');
        }
    }

    //O método "Calculate" recebe os dois números e o operador e retorna o resultado
    class Calculator
    {
        public double Calculate(double num1, double num2, char operador)
        {

	    //executa diferentes blocos de código com base no valor de uma expressão ou variável.
            switch (operador)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 == 0)
                    {
			//caso a divisão seja feita com 0
                        return double.NaN;
                    }
                    else
                    {
                        return num1 / num2;
                    }
                default:

		    //"throw new ArgumentException" é usado para sinalizar que ocorreu um erro relacionado ao argumento (no caso, o operador) e permite que o programa trate essa situação de maneira apropriada, exibindo uma mensagem de erro ou tomando outras ações necessárias.
                    throw new ArgumentException("Operador inválido!");
            }
        }
    }
}