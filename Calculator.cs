using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-Vindo a este projeto de calculadora. Este é o primeiro projeto em C# que realizo");

        double num1, num2, resultado; // os valores são do tipo "double" para ser possível realizar contas com decimais
                                      // outros tipos que poderiam ser usados: float ou decimal

        Console.WriteLine("VAMOS COMEÇAR! Digite o primeiro número a ser calculado: ");
        num1 = double.Parse(Console.ReadLine()); // conversão explícita para o caso do valor a ser digitado for um número decimal

        Console.WriteLine("ÓTIMO! Digite o segundo número a ser calculado: ");
        num2 = double.Parse(Console.ReadLine()); // conversão explícita para o caso do valor a ser digitado for um número decimal

        Console.WriteLine("Agora escolha a operação que deseja realizar. SÓ PODE ESCOLHER ENTRE AS 4 OPÇÕES");
        Console.WriteLine("1 - adição");
        Console.WriteLine("2 - subtração");
        Console.WriteLine("3 - multiplicação");
        Console.WriteLine("4 - divisão \n");
        int operacao = int.Parse(Console.ReadLine()); // conversão explícita para que o valor seja um número inteiro de 1 a 4
        if (operacao >= 5)
        {
            Console.WriteLine("Não há esta possibilidade.");
        }

        switch (operacao)
        {
            case 1:
                resultado = Adicao(num1, num2);
                break;
                // para o caso da operação escolhida for ADIÇÃO

            case 2:
                resultado = Subtracao(num1, num2);
                break;
                // para o caso da operação escolhida for SUBTRAÇÃO

            case 3:
                resultado = Multiplicacao(num1, num2);
                break;
                // para o caso da operação escolhida for MULTIPLICAÇÃO

            case 4:
                if (num2 != 0) // se o 2° número digitado for diferente de 0, então a divisão deverá ser feita
                    resultado = Divisao(num1, num2);
                else
                {
                    Console.WriteLine("Erro: Divisão por zero!"); // se o 2° número digitado for igual a 0, então deverá parar a calculadora
                    return;
                }
                break;

            default:
                Console.WriteLine("Operação inválida.");
                return;
                // para caso os switchs não puderem ser executados
        }

        Console.WriteLine("Resultado: " + resultado);
    }

    //MÉTODOS PARA REALIZAR AS CONTAS
    public static double Adicao(double num1, double num2)
    {
        double result = num1 + num2;
        return result;
    }

    public static double Subtracao(double num1, double num2)
    {
        double result = num1 - num2;
        return result;
    }

    public static double Multiplicacao(double num1, double num2)
    {
        double result = num1 * num2;
        return result;
    }

    public static double Divisao(double num1, double num2)
    {
        double result = num1 / num2;
        return result;
    }
}
