using System;
using Target_Project.Models;

class Program
{
    static void Main()
    {
        CalcularSoma();
        VerificarFibonacci();
        Faturamento();
        FatPorEstado();
        InverteString();
    }

    static void CalcularSoma()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine("Resultado da soma: " + SOMA);
    }

    static void VerificarFibonacci()
    {
        Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());

        if (Fibonacci.PertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static void Faturamento()
    {
        List<(int Dia, double Valor)> faturamentos = new List<(int, double)>
        {
            (1, 22174.1664),
            (2, 24537.6698),
            (3, 26139.6134),
            (4, 0.0),
            (5, 0.0),
            (6, 26742.6612),
            (7, 0.0),
            (8, 42889.2258),
            (9, 46251.174),
            (10, 11191.4722),
            (11, 0.0),
            (12, 0.0),
            (13, 3847.4823),
            (14, 373.7838),
            (15, 2659.7563),
            (16, 48924.2448),
            (17, 18419.2614),
            (18, 0.0),
            (19, 0.0),
            (20, 35240.1826),
            (21, 43829.1667),
            (22, 18235.6852),
            (23, 4355.0662),
            (24, 13327.1025),
            (25, 0.0),
            (26, 0.0),
            (27, 25681.8318),
            (28, 1718.1221),
            (29, 13220.495),
            (30, 8414.61)
        };

        double menorValor = faturamentos.Min(f => f.Valor);
        double maiorValor = faturamentos.Max(f => f.Valor);

        var diasComFat = faturamentos.Where(f => f.Valor > 0.0).ToList();
        double mediaMensal = diasComFat.Average(f => f.Valor);

        int diasAcimaMed = diasComFat.Count(f => f.Valor > mediaMensal);

        Console.WriteLine($"Menor valor de faturamento: {menorValor}");
        Console.WriteLine($"Maior valor de faturamento: {maiorValor:F2}");
        Console.WriteLine($"Média mensal (ignorando dias sem faturamento): {mediaMensal:F2}");
        Console.WriteLine($"Número de dias com faturamento superior à média: {diasAcimaMed}");
    }

    static void FatPorEstado()
    {
        var fat = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        double fatTotal = 0;
        foreach(var valor in fat.Values)
        {
            fatTotal += valor;
        }

        foreach (var estado in fat)
        {
            double percentual = (estado.Value / fatTotal) * 100;
            Console.WriteLine($"O percentual de representação de {estado.Key} foi {percentual:F2}%");
        }
    }

    static void InverteString(){
        Console.WriteLine("Digite uma string para inverter: ");
        string entrada = Console.ReadLine();

        char[] caracteres = entrada.ToCharArray();

        int inicio = 0;
        int fim = caracteres.Length - 1;

        while (inicio < fim)
        {
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            inicio++;
            fim--;
        }

        string stringInvert = new string(caracteres);
        Console.WriteLine("String invertida: " + stringInvert);
    }
}
